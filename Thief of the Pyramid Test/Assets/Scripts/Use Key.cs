using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UseKey : MonoBehaviour
{
    public BoolCheck BC;
    public GameObject door;
    public GetKey GK;
    public Text DoKey;
    public Text nope;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        DoKey.enabled = false;
        nope.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {


            DoKey.enabled = true;
            if (BC.DoorUnlock == true)
            {
                BC.Keyuse = true;
            }
            else
            {
                DoKey.enabled = false;
                nope.enabled = true;
            }
        }
    }
}
