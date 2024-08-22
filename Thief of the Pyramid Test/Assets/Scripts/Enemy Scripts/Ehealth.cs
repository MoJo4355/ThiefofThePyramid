using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class Ehealth : MonoBehaviour
{
    public int Health;

    public Attack atk;
    public NavMeshAgent agent;
    public GameObject Enm;
    public Collider GCollider;


    // Start is called before the first frame update
    public void Awake()
    {

    }

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        GCollider = GetComponent<Collider>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Health <= 0)
        {
            GCollider.isTrigger = true;
            gameObject.GetComponent<Animator>().SetFloat("locomotion", 0);
            gameObject.GetComponent<Animator>().SetBool("isDead", true);
            Destroy(gameObject, 2);
        }

        while(Health <= -10)
        {

        }

    }

    private void OnCollisionEnter(Collision collision){
        if(collision.gameObject.name == "Bullet"){
            Health -= 10;

            if (Health <= 0)
            {
                GCollider.isTrigger = true;
                agent.enabled = false;
                gameObject.GetComponent<Animator>().SetFloat("locomotion", 0);
                gameObject.GetComponent<Animator>().SetBool("isDead", true);
                Destroy(gameObject, 2.3f);
               
            }
        }
    }
}
