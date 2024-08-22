using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_walk : MonoBehaviour
{
    public GameObject Enemy;
    public GameObject WalkingPharaoh;
    public GameObject WalkingMummy;
    public GameObject Self;

    public int randinte;
    // Start is called before the first frame update
    private void Awake()
    {

    }
    void Start()
    {
        Makedue();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Makedue()
    {
        randinte = Random.Range(0, 100);
        if(randinte <= 80){
            Enemy = WalkingMummy.gameObject;
        }
        else if(randinte >= 81){
        Enemy = WalkingPharaoh.gameObject;
        }
        GameObject enemyinstance = Instantiate(Enemy, Self.transform.position, Self.transform.rotation) as GameObject;
        Ehealth bleh = enemyinstance.GetComponent<Ehealth>();
        EnemyNav En = enemyinstance.GetComponent<EnemyNav>();
    }
}
