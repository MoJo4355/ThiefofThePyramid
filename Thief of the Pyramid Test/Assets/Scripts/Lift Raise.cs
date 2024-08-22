using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiftRaise : MonoBehaviour
{
    public GameObject lift;
    public bool liftOn;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(liftOn == true)
        {
            if (gameObject.transform.position.y < 50)
            {
                transform.Translate(0f, 0.025f, 0f);
            }
            else if (gameObject.transform.position.y >= 50)
            {
                transform.Translate(0f, 0f, 0f);
                liftOn = false;

            }
        }
    }

    private void OnTriggerStay(Collider other)
    {

        Debug.Log(other.name);
        if(other.name == "Player_Test")
        {
            liftOn = true;
           
        }
    }
}
