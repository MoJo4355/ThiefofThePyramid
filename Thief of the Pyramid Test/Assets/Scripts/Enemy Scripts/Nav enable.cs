using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.AI;

public class Navenable : MonoBehaviour
{
    public BoolCheck BC;
    public EnemyNav EN;
    public GameObject GM;
    public GameObject lootrigger;
    public GameObject trapped;
    public LevelOneTriggers LOT;
    public string SceneName;
    public Scene scene;
    public NavMeshAgent agent;
    // Start is called before the first frame update
    void Start()
    {
        GM = GameObject.FindWithTag("Controller");
        BC = GM.GetComponent<BoolCheck>();
        scene = SceneManager.GetActiveScene();
        SceneName = scene.name;
        agent = GetComponent<NavMeshAgent>();
        trapped = gameObject;


        if (SceneName == "Level 1")
        {
            lootrigger = GameObject.FindWithTag("Respawn");
            LOT = lootrigger.GetComponent<LevelOneTriggers>();
        }

    }

    // Update is called once per frame
    void Update()
    {
        GM = GameObject.FindWithTag("Controller");
        BC = GM.GetComponent<BoolCheck>();

        if (SceneName == "Level 1")
        {
            lootrigger = GameObject.FindWithTag("Respawn");
            LOT = lootrigger.GetComponent<LevelOneTriggers>();

            
            if (LOT.TWTrapEnemy == true)
            {

                if(trapped.name == "MummyTrapped(Clone)" || trapped.name == "PharaohTrapped(Clone)")
                {

                    EN = trapped.GetComponent<EnemyNav>();
                    EN.enabled = true;
                    Invoke("EnNavOff", 0.01f);
                }

            }

           
        }
        if (BC.EnemyNavEnable == true)
        {
            EN = gameObject.GetComponent<EnemyNav>();
            EN.enabled = true;
            Invoke("EnNavOff", 0.1f);

        }
        if (BC.deathHelp == true)
        {
            EN = gameObject.GetComponent<EnemyNav>();
            if(SceneName == "Tutorial")
            {
                LOT.TWTrapEnemy = false;
            }
            EN.enabled = false;
            agent.enabled = false;
            Invoke("deathHelpOff", 0.1f);
        }
    }

    public void EnNavOff()
    {
        if(SceneName == "Level 1")
        {
            LOT.TWTrapEnemy = false;
        }

    }

    public void deathHelpOff()
    {
        BC.EnemyNavEnable = false;
        
    }
}
