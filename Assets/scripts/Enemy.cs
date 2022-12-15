using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{

    public NavMeshAgent agent;
    [SerializeField] private Transform Player;
    [SerializeField] private GameObject DeathUI;
    [SerializeField] private bool attack=true;
    private float time;

   void Start()
    {
        DeathUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        time+=Time.deltaTime;
        if (attack)
        {
            agent.SetDestination(Player.position);
            gameObject.SetActive(true);
        }
        else
        {
            gameObject.SetActive(false);
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Player")
        {
            DeathUI.SetActive(true);
        }
    }
    public void EnemyStalk()
    {
       
    }
    }
