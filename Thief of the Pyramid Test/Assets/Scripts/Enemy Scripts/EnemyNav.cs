using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class EnemyNav : MonoBehaviour
{
    public NavMeshAgent agent;
    public GameObject Player;
    public AudioSource Groan;


    // Start is called before the first frame update
    public void Start()
    {


        Groan = gameObject.GetComponent<AudioSource>();
        Groan.Play();
        agent = GetComponent<NavMeshAgent>();
        Player = GameObject.FindWithTag("Player");
        if(name == "MummyTrapped(Clone)")
        {
            gameObject.GetComponent<Animator>().SetFloat("locomotion", 1);
        }else if (name == "MummyM(Clone)" || name == "MummyM")
        {
            gameObject.GetComponent<Animator>().SetFloat("locomotion", 1);
        }else if(name == "WalkingMummy(Clone)")
        {
            gameObject.GetComponent<Animator>().SetFloat("locomotion", 1);
        }else if (name == "Pharaoh(Clone)" || name == "WalkingPharaoh(Clone)")
        {
            gameObject.GetComponent<Animator>().SetFloat("locomotion", 1);
        }
        if (name == "PharaohTrapped(Clone)")
        {
            gameObject.GetComponent<Animator>().SetFloat("locomotion", 1);
        }
    }

    // Update is called once per frame
    public void Update()
    {
        Player = GameObject.FindWithTag("Player");
        agent.SetDestination(Player.transform.position);
        //Invoke("PlayGroan", 5f);
    }

    public void PlayGroan()
    {
        Groan.Play();
        print("YES");
        return;
    }
}
