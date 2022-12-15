using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    public static bool inventoryOn = false;
    public static bool diaryOn = false;
    private float mouseX;
    private float mouseY;
    private float xRotate = 0f;  
    private float sensitivityMouse = 200f;
    public Transform Player;
    

    private void start()
    {

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        
    }

    private void Update()
    {
       
        
        if (diaryOn==false)
        {
            
            mouseX = Input.GetAxis("Mouse X") * sensitivityMouse * Time.deltaTime;
            mouseY = Input.GetAxis("Mouse Y") * sensitivityMouse * Time.deltaTime;
            xRotate -= mouseY;
            xRotate = Mathf.Clamp(xRotate, -90f, 90f);
            transform.localRotation = Quaternion.Euler(xRotate, 0f, 0f);
            Player.Rotate(mouseX * Vector3.up);
        }

    }
}
