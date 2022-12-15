using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float standSpeed = 1;
    public float speed = 1;
    public Camera cam;
    public static float StaminaScore = 1f;
    public bool move = false;
    public KeyCode x;
    void start()
    {
        StaminaScore = 1f;
    }
    void Update()
    {
        Move();
        GameInterface.StaminaScore = StaminaScore;
        if (StaminaScore < (float)0.25)
        {
            speed = (float)1;
            standSpeed = (float)1;
        }
        else
        {
            speed = 2;
            standSpeed = 2;
        }
    }
    public void Move()
    {

        
        if (Input.GetKey(KeyCode.LeftShift))
        {
            
            speed = standSpeed * 2;
           
                
                if (StaminaScore > 0&&move)
                    StaminaScore -= (float)0.1 * Time.deltaTime;

            
        }
        else
        {
            if (StaminaScore < 1) { StaminaScore += (float)0.1 * Time.deltaTime; }
            
            speed = standSpeed;
        }



        if (StaminaScore > 0)
        {
            
            if (Input.GetKey(KeyCode.W))
            {
                move = true;
                transform.localPosition += transform.forward * speed * Time.deltaTime;
            }
            else
            {
                move = false;
            }
            if (Input.GetKey(KeyCode.S))
            {
                move = true;
                transform.localPosition += -transform.forward * speed * Time.deltaTime;
            }
            else
            {
                move = false;
            }
            if (Input.GetKey(KeyCode.D))
            {
                move = true;
                transform.localPosition += transform.right * speed * Time.deltaTime;
            }
            else
            {
                move = false;
            }
            if (Input.GetKey(KeyCode.A))
            {
                move = true;
                transform.localPosition += -transform.right * speed * Time.deltaTime;
            }
            else
            {
                move = false;
            }
        }
        if (Input.GetKey(KeyCode.LeftControl))
        {

        }
    }
   
}

