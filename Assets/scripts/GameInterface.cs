using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameInterface : MonoBehaviour
{
    
    public static float StaminaScore;
    public Image Stamina;
    [SerializeField] private GameObject diary;    
    public static Rigidbody DrugObject;
    public byte psyceScore = 100;
    public static bool  diaryOn = false;
    public GameObject DeathUI;

    void Start()
    {
        StaminaScore = 1f;
       
    }
    void Update()
    {
        //stamina
       Stamina.fillAmount = StaminaScore;
        //inventory

        PlayerCamera.diaryOn = diaryOn;
        //diary
        if (Input.GetKeyDown(KeyCode.J)&&diaryOn==false)
        {

            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            diary.SetActive(true);
            diaryOn = true;
        }
        else if (Input.GetKeyDown(KeyCode.J)&&diaryOn==true)
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
            diary.SetActive(false);
                diaryOn = false;
        }
       
         
        
        //deathMenu
        if (DeathUI.activeInHierarchy == true)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            Time.timeScale = 0;
        }
    }
   
    
}
