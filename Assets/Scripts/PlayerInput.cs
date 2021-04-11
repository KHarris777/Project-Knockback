using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class PlayerInput : MonoBehaviour
{
    public CharacterController controller;

    public float speed = 12f;
    public float gravity = -9.81f;

    Vector2 moveVec = Vector2.zero;
   
    public float jumpHeight = 3f;

    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;

    Vector3 velocity;
    bool isGrounded;
    
    public Controls controls = null;

    public Camera playerCam;

    public float damage = 10f;
    public float ammoCount = 3f;

    public float knockbackForce;

    public GameObject AmmoWarning;
    public Text AmmoLabel;

    public ParticleSystem muzzleFlash;
    public ParticleSystem bulletTrail;

    [HideInInspector] public bool hasFired = false;

    [SerializeField] private GameObject ppVolume;
    [SerializeField] private GameObject greenLight;
    [SerializeField] private GameObject redLight;

    public float meleeRange = 10f;
    public float meleeDamage = 20f;
    [HideInInspector] public bool hasPunched = false;
    [SerializeField] private GameObject normalArm;
    [SerializeField] private GameObject punchingArm;

    private void Awake()
    {
        controls = new Controls();
        //cam = Camera.main;

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
   
    private void OnEnable()
    {
        controls.PlayerInput.Enable();
   
    }

    private void OnDisable()
    {
        controls.PlayerInput.Disable();
        
    }
    private void FixedUpdate()
    {
        Move();
    }

    void Update()
    {
        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);

        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;

        }

        AmmoLabel.text = ammoCount.ToString();

        if (isGrounded == true)
        {
            ammoCount = 3f;
            AmmoWarning.SetActive(false);

        }

        if(ammoCount <= 1f)
        {
            AmmoWarning.SetActive(true);
        }
        if (ammoCount <= 0f)
        {
            redLight.SetActive(true);
            greenLight.SetActive(false);
        }
        if (ammoCount > 0f)
        {
            redLight.SetActive(false);
            greenLight.SetActive(true);
        }
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        moveVec = context.ReadValue<Vector2>();
    }

    public void Move()
    {
        var movement = new Vector3()
        {
            x = moveVec.x,
            z = moveVec.y
        }.normalized;

        transform.Translate(movement * speed * Time.deltaTime);
    }

    public void OnJump(InputAction.CallbackContext context)
    {
        if (context.performed == true)
        {

            if (isGrounded == true)
            {

                velocity.y = Mathf.Sqrt(jumpHeight * -1f * gravity);
            
            }
        }
    }


    public void OnShoot(InputAction.CallbackContext context)
    {
        if (context.performed == true)
        {
            if(hasFired == false)
            {
                StartCoroutine(FireRate());
                StartCoroutine(MeleeRate());

                if (ammoCount >= 1)
                {
                    RaycastHit hit;
                    --ammoCount;
                    muzzleFlash.Play();
                    bulletTrail.Play();
                    AudioManager.Instance.Play("Shoot");

                    if (Physics.Raycast(playerCam.transform.position, playerCam.transform.forward, out hit))
                    {
                        Target target = hit.transform.GetComponent<Target>();

                        if (target != null)
                        {
                            target.TakeDamage(damage);
                            AudioManager.Instance.Play("Hit");
                        }
                    }

                    Knockback();
                }
            }
            else
            {
                return;
            }
            
        }
    }

    private IEnumerator FireRate()
    {
        hasFired = true;
        yield return new WaitForSeconds(0.45f);
        hasFired = false;
    }
    

    public void Knockback()
    {
        ppVolume.SetActive(true);
        
        Vector3 direction = playerCam.transform.forward * -1;

        velocity = direction * Mathf.Sqrt(knockbackForce * -2f * gravity);

        Invoke("StopSliding", 0.5f);

    }

    void StopSliding()
    {
             
        velocity = Vector3.zero;
        ppVolume.SetActive(false);
    }

    public void OnMelee(InputAction.CallbackContext context)
    {
        if (context.performed == true)
        {
            if (hasPunched == false)
            {
                StartCoroutine(FireRate());
                normalArm.SetActive(false);
                punchingArm.SetActive(true);
                StartCoroutine(MeleeRate());
                RaycastHit hit;
                
                if (Physics.Raycast(playerCam.transform.position, playerCam.transform.forward, out hit, meleeRange))
                {
                    Target target = hit.transform.GetComponent<Target>();

                    if (target != null)
                    {
                        target.TakeDamage(meleeDamage);
                        AudioManager.Instance.Play("MeleeHit");
                    }
                }

            }
            else
            {
                return;
            }

        }
    }
    private IEnumerator MeleeRate()
    {
        
        hasPunched = true;
        yield return new WaitForSeconds(0.1f);
        normalArm.SetActive(true);
        punchingArm.SetActive(false);
        yield return new WaitForSeconds(0.35f);
        hasPunched = false;
    }

}
