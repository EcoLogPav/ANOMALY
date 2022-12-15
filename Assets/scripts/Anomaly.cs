using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
public class Anomaly : MonoBehaviour
{
    
    private float award = 500; 
    private float position; 
    private float anomalyType;
    [SerializeField] private Dropdown dropdown;
    [SerializeField] private TMP_Text firstProof;
    [SerializeField] private GameObject diaryUI;
    [SerializeField] private GameObject OverUI;
    [SerializeField] private GameObject AnEnemy1;
    [SerializeField] private GameObject AnEnemy2;
    [SerializeField] private GameObject Player;
    [SerializeField] private GameObject DeathUI;


    
    void Start()
    {
        firstProof.text = "0";
        AnEnemy1.SetActive(false);
        AnEnemy2.SetActive(false);
        position = Random.Range(0, 5);
        anomalyType = Random.Range(1, 4);
        switch (position)
        {
            case 0:
                transform.position = new Vector3(35, 2, 0);
                break;

            case 1:
                transform.position = new Vector3(35, 2, 7);
                break;
            case 2:
                transform.position = new Vector3(26, 2, -7);
                break;
            case 3:
                transform.position = new Vector3(26, 2, -1);
                break;
            case 4:
                transform.position = new Vector3(21, 2, -7);
                break;
        }
        switch (anomalyType)
        {
            case 1:
                AnEnemy1.SetActive(true);
                AnEnemy1.transform.position = transform.position;
                break;
            case 2:
                AnEnemy2.SetActive(true);
                AnEnemy2.transform.position = transform.position;
                break;
            case 3:
                AnEnemy1.SetActive(true);
                AnEnemy2.SetActive(true);
                AnEnemy1.transform.position = transform.position-new Vector3(5,0,0);
                AnEnemy2.transform.position = transform.position - new Vector3(5, 0, 0);
                break;

        }
    }
  void Update()
    {
       
        if (dropdown.value == anomalyType)
        {
            firstProof.text = "+"+award;
        }
        else if (dropdown.value != anomalyType)
        {
            firstProof.text = "+"+0;
        }


    }
    
    
    public void OverUIOn()
    {
        OverUI.SetActive(true);
     diaryUI.SetActive(false);
      
    }
    public void ExitWithProcess()
    {
        SceneManager.LoadScene("MainMenu");

    }

}
