using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wakeUp : MonoBehaviour
{
    public Attack ak;
    public PlayerMovement PM;
    public PickUp PU;
    public Light lght;
    public PlayerHealth PH;

    public void Awake()
    {
        ak.enabled = true;
        PM.enabled = true;
        PU.enabled = true;
        lght.enabled = true;
        PH.enabled = true;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
