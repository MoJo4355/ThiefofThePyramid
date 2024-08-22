using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class CurseMove : MonoBehaviour
{
    public GameObject Player;
    public LevelOneTriggers lot;
    public float rampupspeed;
    public BoolCheck BC;


    // Start is called before the first frame update
    void Start()
    {
        rampupspeed = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if(lot.WakeUp == true)
        {
            if(Player.transform.position.z <= gameObject.transform.position.z - 7)
            {
                transform.Translate(0f, 0.01f + rampupspeed, 0f);
                rampupspeed += 0.001f;
            }
            else if(Player.transform.position.z <= gameObject.transform.position.z - 30)
            {
                transform.Translate(0f, 0.02f + rampupspeed, 0f);
                rampupspeed += 0.015f;
            }
            else
            {
                transform.Translate(0f, 0.01f, 0f);
                rampupspeed = 0;
            }
        }
        if(Player.transform.position.z > gameObject.transform.position.z)
        {
            BC.GameOver();
        }
    }
}
