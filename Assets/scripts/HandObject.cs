using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandObject : MonoBehaviour
{
    [SerializeField]private GameObject flashLight;
    [SerializeField] private GameObject psychoVaccine;
    [SerializeField] private GameObject Light;
    [SerializeField] private GameObject ED;
    [SerializeField] private GameObject Radio;
    [SerializeField] private GameObject DAA;
    public static Rigidbody DrugObject;
    public static bool armTag;
    public static bool lighty = false;


    void Update()
    {
        switch (DrugObject.name) {
            case "FlashLight":
                
                
                if (armTag == true)
                {
                    flashLight.SetActive(true);
                }
                else
                {
                    flashLight.SetActive(false);
                }
                if (Input.GetMouseButtonDown(1)&&lighty==false)
                {
                    
                    lighty = true;
                    Light.SetActive(true);
                }
                else if(Input.GetMouseButtonDown(1) && lighty == true)
                {
                    lighty = false;
                    Light.SetActive(false);
                }
               
                break;
            case "psychoVaccine":


                if (armTag == true)
                {
                    psychoVaccine.SetActive(true);
                }
                else
                {
                    psychoVaccine.SetActive(false);
                }
                

                break;
            case "ED":


                if (armTag == true)
                {
                    ED.SetActive(true);
                }
                else
                {
                    ED.SetActive(false);
                }


                break;
            case "radio":


                if (armTag == true)
                {
                    Radio.SetActive(true);
                }
                else
                {
                    Radio.SetActive(false);
                }


                break;

            case "DAA":


                if (armTag == true)
                {
                    DAA.SetActive(true);
                }
                else
                {
                    DAA.SetActive(false);
                }


                break;
            default:
               
                break;
            }
       


    }
}
