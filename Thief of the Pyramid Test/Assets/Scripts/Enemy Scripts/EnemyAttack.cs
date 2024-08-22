using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using UnityEngine.UI;
using UnityEngine.AI;

public class EnemyAttack : MonoBehaviour
{
    public int hearts;
    public GameObject[] lives;
    public GameObject BG;
    public GameObject Player;
    public int Health;
    public int randintg;
    public BoolCheck BC;
    public PlayerHealth PH;
    public GameObject Enemy;
    public NavMeshAgent agent;
    public Animator Eanim;
    public Ehealth EH;
    //public GameObject GameManager;
    public bool attackon;
    

    // Start is called before the first frame update

    void Awake()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
         PH = Player.GetComponent<PlayerHealth>();
        Enemy = gameObject.transform.parent.gameObject;
        Debug.LogError(Enemy);
        agent = Enemy.GetComponent<NavMeshAgent>();
        Eanim = Enemy.GetComponent<Animator>();
        EH = Enemy.GetComponent<Ehealth>();

        Time.timeScale = 1;
    }
    void Start()
    {
         Player = GameObject.Find("Player");
         PH = Player.GetComponent<PlayerHealth>();
        //GameManager = GameObject.FindWithTag("Controller");

        //hearts = 3;
        //GameOverCanvas.SetActive(false);
        Player.SetActive(true);
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if(EH.Health <= 0)
        {
            gameObject.SetActive(false);
        }
    }

    void onHit()
    {
         PH = Player.GetComponent<PlayerHealth>();
        if (PH == null)
        {
            Player = GameObject.FindWithTag("Player");
             PH = Player.GetComponent<PlayerHealth>();
        }

        if(PH.isAttackable == true)
        {
            randintg = Random.Range(10, 15);
            PH.phealth -= randintg;
            //agent.enabled = false;
            Eanim.SetBool("isAttacking", true);
            //GameManager = GameObject.FindWithTag("Controller");
            //BoolCheck BC = GameManager.GetComponent<BoolCheck>();
            //BC.eyespy -= 1;
            //BC.hortes[BC.eyespy].SetActive(false);
            attackon = true;
            Invoke("StopAttacking", 1);

        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(PH == null)
        {
            Player = GameObject.FindWithTag("Player");
            PH = Player.GetComponent<PlayerHealth>();
        }
        if(other.gameObject.tag == "Player")
        {
            //GameManager = GameObject.FindWithTag("Controller");
            onHit();
        }
    }

    public void GameEnd()
    {
        Time.timeScale = 0;
        Player.SetActive(false);
    }
    public void StopAttacking()
    {
        Eanim.SetBool("isAttacking", false);
    }
}
