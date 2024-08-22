using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;
using UnityEngine.UI;

public class keyinteracrt : MonoBehaviour
{
    public GetKey gk;
    public BoolCheck BC;
    public Text Interact;
    public UseKey UK;
    public GameObject[] boo;
    public EnemyNav En;
    public Spawner Spawnr;

    // Start is called before the first frame update
    void Start()
    {
        gk.keygrab = false;
        En.enabled = false;
        if(boo == null)
        {
            boo = GameObject.FindGameObjectsWithTag("Enemy");

        }
       
    }

    // Update is called once per frame
    void Update()
    {
        if (gk.keygrab == true)
        {
            if (Input.GetKeyDown("space"))
            {
                gk.oopsies();
                gk.keygrab = false;
                Interact.enabled = false;

            }
        }

        if(BC.Keyuse == true)
        {
           
            if (Input.GetKeyDown("space"))
            {
                GameObject[] boo = GameObject.FindGameObjectsWithTag("Enemy");
                UK.DoKey.enabled = false;
                Destroy(UK.door.gameObject);
                En.enabled = true;
            }
        }
    }
}
