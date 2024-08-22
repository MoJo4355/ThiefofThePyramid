using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Attack : MonoBehaviour
{
    public GameObject HitBox;
    public GameObject BCluster;

    public EnemyAttack EA;

    public Camera cam;

    public float cooldownTime = 5f;
    private float lastUsedTime;

    private float distance;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
       
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Vector3 frontOffset = new Vector3(0, -0.2f, 0);
            GameObject Bazinga = (GameObject)Instantiate(HitBox, cam.transform.position + cam.transform.forward + frontOffset, cam.transform.rotation);
        }
        else if (Input.GetKeyDown(KeyCode.Mouse1) && Time.time > lastUsedTime + cooldownTime)
        {
            Vector3 frontOffset = new Vector3(0, -0.2f, 0);
            GameObject Cluster = (GameObject)Instantiate(BCluster, cam.transform.position + cam.transform.forward + frontOffset, cam.transform.rotation);
            lastUsedTime = Time.time;
        }
    }
}
