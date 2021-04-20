using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class MouseLook : MonoBehaviour
{
    Vector2 lookVec;
   
    public float sensitivityY = 10f;
    public float sensitivityX = 10f;

    public Transform player;

    //public Camera cam;
    public Transform cameraHolder;

    public GameObject MenuUI;
    private bool isPaused;
    public Text SensYValue;
    public Text SensXValue;

    private void Update()
    {
        SensXValue.text = sensitivityX.ToString();
        SensYValue.text = sensitivityY.ToString();
    }

    private void LateUpdate()
    {
        transform.position = cameraHolder.position;  
    }

    private void FixedUpdate()
    {
        Look();
    }

    public void OnLook(InputAction.CallbackContext context)
    {
       
        Vector2 lookValue = context.ReadValue<Vector2>();

        lookVec.x += -lookValue.y * sensitivityY * Time.deltaTime;
        lookVec.y += lookValue.x * sensitivityX * Time.deltaTime;

    }

    public void Look()
    {                
        lookVec.x = Mathf.Clamp(lookVec.x, -90, 90);
        transform.rotation = Quaternion.Euler(lookVec);

        Vector3 vNew = new Vector3(0, lookVec.y, 0);
        player.transform.localEulerAngles = vNew;

        //Vector3 smoothMov = Vector3.Lerp(transform.position, cameraHolder.position, 2f);
        //transform.position = smoothMov;

        //player.transform.localRotation = Quaternion.Euler(0, lookVec.y, 0);
        //player.transform.localEulerAngles = (Vector3.up * lookVec.y);
    }
   
    
    public void Pause(InputAction.CallbackContext context)
    {
        if (context.performed == true)
        {
           if(isPaused == false)
            {
                MenuUI.SetActive(true);
                isPaused = true;
            }
           
        }
    }

    public void ExitMenu(InputAction.CallbackContext context)
    {
        if (context.performed == true)
        {
           if(isPaused == true)
            {
                MenuUI.SetActive(false);
                isPaused = false;
            }
            else
            {
                return;
            }

        }
    }

    public void IncreaseX(InputAction.CallbackContext context)
    {
        if (context.performed == true)
        {
            if(isPaused == true)
            {
                ++sensitivityX;
            }
          
        }
    }
    public void DecreaseX(InputAction.CallbackContext context)
    {
        if (context.performed == true)
        {
            if (isPaused == true)
            {
                --sensitivityX;
            }
        }
    }
    public void IncreaseY(InputAction.CallbackContext context)
    {
        if (context.performed == true)
        {
            if (isPaused == true)
            {
                ++sensitivityY;
            }
        }
    }
    public void DecreaseY(InputAction.CallbackContext context)
    {
        if (context.performed == true)
        {
            if (isPaused == true)
            {
                --sensitivityY;
            }
        }
    }

    //Old look code

    //float lookVecY;
    //float lookVecX;

    //private float camRot = 0;
    //public float sensitivity = 30;

    //public Transform player;
    //public Transform playerCam;

    /*public void OnLook(InputAction.CallbackContext context)
    {
        //lookVecX = context.ReadValue<Vector2>().x * sensitivity * Time.deltaTime;
        //lookVecY = context.ReadValue<Vector2>().y * sensitivity * Time.deltaTime;

        Vector2 lookValue = context.ReadValue<Vector2>();

        lookVec.x += -lookValue.y * 0.022f * sensitivity;
        lookVec.y += lookValue.x * 0.022f * sensitivity;

    }*/

    /*public void Aim()
    {
        lookVecY = Mathf.Clamp(lookVecY, -90, 90);
        player.localEulerAngles = new Vector3(0, lookVecX, 0);
        playerCam.localEulerAngles = new Vector3(camRot, 0, 0);


        
    
         float mouseX = controls.PlayerInput.Aim.ReadValue<Vector2>().x * sensitivity * Time.deltaTime;
         float mouseY = controls.PlayerInput.Aim.ReadValue<Vector2>().y * sensitivity * Time.deltaTime;

         camRot -= mouseY;
         camRot = Mathf.Clamp(camRot, -90, 90);

         cam.transform.localRotation = Quaternion.Euler(camRot, 0, 0);
         transform.Rotate(Vector3.up * mouseX);

        
    
        
        camRot -= lookVecY;
        camRot = Mathf.Clamp(camRot, -90, 90);

        cam.transform.localRotation = Quaternion.Euler(camRot, 0, 0);
        transform.Rotate(Vector3.up * lookVecX);
    }*/
}
