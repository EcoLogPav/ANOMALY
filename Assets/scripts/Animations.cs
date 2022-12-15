using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animations : MonoBehaviour
{
    public Animation Door;
   public bool door=true;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab)&&door==true)
        {
            Door.Play("door");
            door=false;
            
        }
        else if(Input.GetKeyDown(KeyCode.Tab) && door == false)
        {
            Door.Play("doorCLose");
            door =true;
        }
    }
}
