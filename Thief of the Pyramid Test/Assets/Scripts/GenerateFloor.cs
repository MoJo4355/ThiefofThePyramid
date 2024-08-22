using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateFloor : MonoBehaviour
{
    public GameObject Floor;

    public GameObject spawnerOne;
    public int spawnChooser;
    public int stopper;
    public GameObject fakeKey;
    public GameObject SUPERPHAROAH;
    public GameObject HelperObject;
    public Level2Helper LH;
    public GameObject wall;

    // Start is called before the first frame update
    void Start()
    {
        if(LH == null)
        {

            HelperObject = GameObject.FindWithTag("Helper");
            LH = HelperObject.GetComponent<Level2Helper>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {

            if (LH.stopHallGen >= 50)
            {
                Vector3 randal = new Vector3(0, 1.5f, 0);
                Instantiate(SUPERPHAROAH, Floor.transform.position + randal, Floor.transform.rotation);
            }
            else
            {
                Destroy(wall.gameObject);
                Instantiate(Floor, spawnerOne.transform.position, spawnerOne.transform.rotation);
                fakeKey.transform.position = new Vector3(-1, 0, 0);
                LH.stopHallGen += 1;
                Destroy(gameObject);
            }
        }
    }

}
