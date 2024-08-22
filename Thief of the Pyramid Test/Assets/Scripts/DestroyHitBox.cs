using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyHitBox : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 01f);
    }

    // Update is called once per frame
    void Update()
    {
        if(gameObject.name == "Bullet Hole")
        {
            Destroy(gameObject, 5f);
        }
    }
}
