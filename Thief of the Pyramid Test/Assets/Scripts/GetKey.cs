using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetKey : MonoBehaviour
{
    public GameObject Key;
    public Text Interact;
    public bool keygrab;
    public GameObject light;
    public BoolCheck BC;
    public GameObject Guide;
    public GameObject[] lights;
    public int test;
    public int bleh;
    // Start is called before the first frame update
    void Start()
    {
        keygrab = false;
        Interact.enabled = false;
        Guide.SetActive(false);
        test = 0;
        bleh = 0;
    }

    // Update is called once per frame
    void Update()
    {
        while(bleh == 1 && test <= 3){
            if(test == 3)
            {
                Destroy(gameObject);
            }
            test += 1;
            lights[test].SetActive(true);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            keygrab = true;
            Interact.enabled = true;
            print("zoinks");
        }
    }

    public void oopsies()
    {
        Destroy(light.gameObject);
        keygrab = false;
        BC.DoorUnlock = true;
        Guide.SetActive(true);
        bleh += 1;
    }


}
