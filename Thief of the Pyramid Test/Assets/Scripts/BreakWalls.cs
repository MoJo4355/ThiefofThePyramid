using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakWalls : MonoBehaviour
{
    public int hits;
    public GameObject wall;
    public Level2Helper LH;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            if(hits >= 10)
            {
                Destroy(wall.gameObject);
                LH.totalWallsBroken += 1;
            }
            else
            {
                hits += 1;
            }


        }
    }
}
