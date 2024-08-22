using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EyeRoom : MonoBehaviour
{

    public GameObject Wall;
    public GameObject WallTwo;
    public Light PlayerTorch;
    public BoolCheck BC;
    public bool Eyetime;
    public int Eyecount;
    public GameObject eyes;
    public GameObject DeadEye;
    public GameObject EyeEnemies;
    public AudioSource HeartBeat;
    public AudioSource Walking;
    public AudioSource Splat;
    // Start is called before the first frame update
    void Start()
    {
        HeartBeat.enabled = false;
        BC.GlobalEnemyCount = Eyecount;
       
    }

    // Update is called once per frame
    void Update()
    {

        Eyecount = GameObject.FindGameObjectsWithTag("eye").Length;
        if(Eyetime == true){
            eyes.SetActive(true);
            BC.GlobalEnemyCount = GameObject.FindGameObjectsWithTag("Enemy").Length;
            EyeEnemies.SetActive(true);
            Walking.enabled = false;
            HeartBeat.enabled = true;
            Invoke("DestroyEye", 1);

            
        }

    }

    public void OnTriggerEnter(Collider other){
        if(other.gameObject.tag == "Player"){
            Wall.SetActive(true);
            WallTwo.SetActive(true);
            PlayerTorch.enabled = false;
            RenderSettings.fogDensity = 0.13f;
            Eyetime = true;
        }
    }

    public void DestroyEye()
    {
        while(BC.GlobalEnemyCount != Eyecount){
                DeadEye = GameObject.FindWithTag("eye");
                Destroy(DeadEye.gameObject);
                Eyecount -=1;
                Splat.Play();
            if(BC.GlobalEnemyCount == 0){
                Wall.SetActive(false);
                WallTwo.SetActive(false);
                PlayerTorch.enabled = true;
                RenderSettings.fogDensity = 0.08f;
                HeartBeat.enabled = false;
                Walking.enabled = true;
                Eyetime = false;
                Destroy(gameObject);
            }
        }
    }
}
