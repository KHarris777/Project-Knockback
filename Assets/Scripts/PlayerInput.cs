using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInput : MonoBehaviour
{
    public CharacterController controller;

    public float speed = 12f;
    public float gravity = -9.81f;
    public float jumpHeight = 3f;

    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;

    Vector3 velocity;
    bool isGrounded;
    
    private Controls controls = null;

    [SerializeField] private InputAction turning;
    private Camera cam = null;
    private float camRot = 0;
    public float mouseSensitivity = 100;

    public float damage = 10f;

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
        turning.Enable();
    }

    private void OnDisable()
    {
        controls.PlayerInput.Disable();
        turning.Disable();
    }


    void Update()
    {
        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);

        
        Move();
        
        Turn();       
    }

    public void Move()
    {
        var movementInput = controls.PlayerInput.Movement.ReadValue<Vector2>();

        var movement = new Vector3()
        {
            x = movementInput.x,
            z = movementInput.y
        }.normalized;

        

        transform.Translate(movement * speed * Time.deltaTime);
    }

    public void Jump()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }
        
        if (isGrounded == true)
        {
           
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }
    }

    public void Turn()
    {
        float mouseX = turning.ReadValue<Vector2>().x * mouseSensitivity * Time.deltaTime;
        float mouseY = turning.ReadValue<Vector2>().y * mouseSensitivity * Time.deltaTime;

        camRot -= mouseY;
        camRot = Mathf.Clamp(camRot, -90, 90);

        cam.transform.localRotation = Quaternion.Euler(camRot, 0, 0);
        transform.Rotate(Vector3.up * mouseX);
    }

    public void OnShoot(InputAction.CallbackContext context)
    {
        if (context.performed == true)
        {
                RaycastHit hit;

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
    }

    public void Knockback()
    {
        Vector3 direction = Camera.main.transform.forward * -1;

        velocity = direction * Mathf.Sqrt(knockbackForce * -2f * gravity);

        Invoke("StopSliding", 0.4f);

        //direction = Mathf.Sqrt(knockbackForce * -2f * gravity);
        //controller.Move(direction * Mathf.Sqrt(knockbackForce * -2f * gravity));
    }

    void StopSliding()
    {
        velocity = Vector3.zero;
    }
}
