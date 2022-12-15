using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] private GameObject pause_UI;
    bool is_paused = false;
    bool change_pause_status = true;
    public GameObject DeathUI;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (DeathUI.activeInHierarchy == false)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                is_paused = !is_paused;
                change_pause_status = true;
            }


            if (change_pause_status)
            {
                if (is_paused)
                {
                    Cursor.lockState = CursorLockMode.None;    
                    Time.timeScale = 0;
                    pause_UI.SetActive(true);
                    change_pause_status = false;
                    Cursor.visible = true;
                }
                else
                {
                    Cursor.lockState = CursorLockMode.Locked;
                    Time.timeScale = 1;
                    pause_UI.SetActive(false);
                    change_pause_status = false;
                    Cursor.visible = false;
                }
            }
        }

    }
    public void ToMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void resume_btn_click_fn()
    {
        is_paused = false;
        change_pause_status = true;
    }
}
