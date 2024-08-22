using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class campos : MonoBehaviour
{
    public GameObject CObject;
    public Transform cameraPosition;

    // Update is called once per frame
   private void Update()
    {
        if(cameraPosition == null){
            CObject = GameObject.FindWithTag("Cposition");
            cameraPosition = CObject.GetComponent<Transform>();
        }
        transform.position = cameraPosition.position; 
    }
}
