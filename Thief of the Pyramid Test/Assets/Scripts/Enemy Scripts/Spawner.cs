using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject Enemy;
    public GameObject Pharaoh;
    public GameObject Mummy;
    public GameObject Self;

    public int randinter;
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
        randinter = Random.Range(0, 100);
        if(randinter <= 70){
            Enemy = Mummy.gameObject;
        }
        else if(randinter >= 71){
        Enemy = Pharaoh.gameObject;
        }
        GameObject enemyinstance = Instantiate(Enemy, Self.transform.position, Self.transform.rotation) as GameObject;
        Ehealth bleh = enemyinstance.GetComponent<Ehealth>();
        EnemyNav En = enemyinstance.GetComponent<EnemyNav>();
    }
}
