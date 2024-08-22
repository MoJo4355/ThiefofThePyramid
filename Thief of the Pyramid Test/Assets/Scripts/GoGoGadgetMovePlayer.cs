using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoGoGadgetMovePlayer : MonoBehaviour
{

    public Transform Player;
    public Transform InSpot;
    public Transform OutSpot;
    public GameObject YellowLight;
    public Light torch;
    public Level2Helper LH;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     public void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.tag == "Player"){
            if(LH.InOrOut == false){
                Player.transform.position = OutSpot.transform.position;
                torch.enabled = false;
                LH.InOrOut = true;
                YellowLight.SetActive(true);
            }else{
                Player.transform.position = InSpot.transform.position;
                torch.enabled = true;
                LH.InOrOut = false;
                YellowLight.SetActive(false);
            }
        }
    }
}
