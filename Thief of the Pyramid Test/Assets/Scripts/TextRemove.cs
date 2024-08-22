using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TextRemove : MonoBehaviour
{
    public Text Interact;
    public Text noKey;
    public Text Equip;
    public Text yesKey;
    public GameObject Screams;
    public GameObject Miscellanious;

    public PickUp Pick;
    // Start is called before the first frame update
    void Start()
    {
        Interact.enabled = false;
        noKey.enabled = false;
        Equip.enabled = false;
        yesKey.enabled = false;
        Miscellanious.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    //This here script gets rid of any bools and text on screen when passing through them
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            Miscellanious.SetActive(false);
            Interact.enabled = false;
            noKey.enabled = false;
            Equip.enabled = false;
            yesKey.enabled = false;
            Pick.DOORSTUCK = false;
        }
    }
}
