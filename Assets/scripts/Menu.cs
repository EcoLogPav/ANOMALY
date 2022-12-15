using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public bool isFullScreen= false;
    public static bool diaryOn = false;
    public void PlayPressed()
    {
         GameInterface.diaryOn=false;
      
        SceneManager.LoadScene("Test");
    }
    public void ToForest()
    {
        GameInterface.diaryOn = false;

        SceneManager.LoadScene("Forest");
    }
    public void Exit()
    {
        Application.Quit();
   
    }
    public void FullScreenToggle()
    {
        isFullScreen = !isFullScreen;
        Screen.fullScreen = isFullScreen;
    }
}
