using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class inventory : MonoBehaviour
{
    private Vector3 Slot1 = new Vector3(-1, 241,0);
    private Vector3 Slot2 = new Vector3(-1, -5,0);
    private Vector3 Slot3 = new Vector3(-1, -241,0);
    [SerializeField] private GameObject inventoryUI;
    [SerializeField] private Image FlashLight;
    [SerializeField] private Image ED;
    [SerializeField] private Image DAA;
    [SerializeField] private Image radio;
    [SerializeField] private Image SelectObj;
    public Rigidbody FirstObj;
    public Rigidbody SecondObj;
    public Rigidbody ThirdObj;
    public static Rigidbody DrugObject;
    public bool is_inventoryOn = false;
   private static Image[] inventoryMas;
    public static byte inventoryStep = 0;
    public bool change_inventory_status;

    void Update()
    {
        //inventory
        //inventoryStep = RaiseThrow.inventoryStep;

        switch (inventoryStep)
        {
            case 0:
                DrugObject = FirstObj;
                break;
                case 1:
                DrugObject = SecondObj;
                break;
                case 2:
                DrugObject = ThirdObj;
                break;
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if(inventoryStep<3)
            inventoryStep++;
            else
            {
                inventoryStep=0;
            }
        }
            if (Input.GetKeyDown(KeyCode.I))
             {
           
                is_inventoryOn = !is_inventoryOn;
                change_inventory_status = true;
            switch (DrugObject.name)
            {
                case "FlashLight":
                    SelectObj = FlashLight;
                    SelectObj.gameObject.SetActive(true);
                    break;
                case "ED":
                    SelectObj = ED;
                    SelectObj.gameObject.SetActive(true);
                    break;
                case "DAA":
                    SelectObj = DAA;
                    SelectObj.gameObject.SetActive(true);
                    break;
                case "radio":
                    SelectObj = radio;
                    SelectObj.gameObject.SetActive(true);
                    break;
            }
            
           
            
            if (inventoryStep == 0)
                    {
                        
                        SelectObj.GetComponent<RectTransform>().anchoredPosition = Slot1;
                

            }
                    else if (inventoryStep == 1)
                    {
                        
                        SelectObj.GetComponent<RectTransform>().anchoredPosition = Slot2;
               

            }
                    else if (inventoryStep == 2)
                    {
                        
                        SelectObj.GetComponent<RectTransform>().anchoredPosition = Slot3;
                
            }
            
        }
        


        if (change_inventory_status)
            {
                if (is_inventoryOn)
                {
                    Cursor.lockState = CursorLockMode.None;
                    Time.timeScale = 0;
                    inventoryUI.SetActive(true);
                    Cursor.visible = true;
                    change_inventory_status = false;
                }
                else
                {
                    Cursor.lockState = CursorLockMode.Locked;
                    Time.timeScale = 1;
                    inventoryUI.SetActive(false);
                    Cursor.visible = false;
                    change_inventory_status = false;
                }
            }
        
        }


    }


