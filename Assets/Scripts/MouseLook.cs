using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MouseLook : MonoBehaviour
{
    Vector2 lookVec;
   
    public float sensitivity = 30f;

    public Transform player;

    public Camera Cam;

    // Update is called once per frame
    void Update()
    {
        Look();  
    }

    public void OnLook(InputAction.CallbackContext context)
    {       
        Vector2 lookValue = context.ReadValue<Vector2>();

        lookVec.x += -lookValue.y * sensitivity * Time.deltaTime;
        lookVec.y += lookValue.x * sensitivity * Time.deltaTime;

    }

    public void Look()
    {
        lookVec.x = Mathf.Clamp(lookVec.x, -80, 80);
        transform.rotation = Quaternion.Euler(lookVec);
        player.transform.localEulerAngles = new Vector3(0, lookVec.y, 0);
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
