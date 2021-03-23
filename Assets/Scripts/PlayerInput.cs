using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInput : MonoBehaviour
{
    public CharacterController controller;

    public float speed = 12f;
    public float gravity = -9.81f;

    Vector2 moveVec = Vector2.zero;
    Vector2 lookVec = Vector2.zero;
    
   
    public float jumpHeight = 3f;

    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;

    Vector3 velocity;
    bool isGrounded;
    
    private Controls controls = null;

    private Camera cam = null;

    public float damage = 10f;
    public float ammoCount = 3f;

    public float knockbackForce;

   

    private void Awake()
    {
        controls = new Controls();
        cam = Camera.main;

        Cursor.lockState = CursorLockMode.Locked;
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
        
        //Move
        //Vector3 move = new Vector3(moveVec.x, 0, moveVec.y);
        //transform.Translate(move * speed * Time.deltaTime);
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

        if (isGrounded == true)
        {
            ammoCount = 3f;

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
            
            if (ammoCount >= 1)
            {
                RaycastHit hit;
                --ammoCount;

                if (Physics.Raycast(cam.transform.position, cam.transform.forward, out hit))
                {
                    Target target = hit.transform.GetComponent<Target>();

                    if (target != null)
                    {
                        target.TakeDamage(damage);
                    }
                }

                Knockback();
            }
            else
            {
                return;
            }
            
        }
    }

    
    public void Knockback()
    {
        Vector3 direction = cam.transform.forward * -1;

        velocity = direction * Mathf.Sqrt(knockbackForce * -2f * gravity);

        Invoke("StopSliding", 0.4f);

    }

    void StopSliding()
    {
             
        velocity = Vector3.zero;     
       
    }

}
