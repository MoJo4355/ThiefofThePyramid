using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BulletGO : MonoBehaviour
{
    // IM THIRSTY IM THIRSTY IM THIRSTY IM THIRSTY, IM JUST GETTING A DRINK IM JUST GETTING A DRINK IM JUST GETTING A DRINK
    public GameObject Bullet;
    public GameObject KeyforFinal;
    public Ehealth womp;
    public bool keydropped;
    public EnemyCheck EC;
    public GameObject Enemy;
    public Scene scene;
    public string SceneName;
    public GameObject BulletHole;
    public int randomint;

    // Start is called before the first frame update
    private void Awake(){

    }

    void Start()
    {

        scene = SceneManager.GetActiveScene();
        SceneName = scene.name;
    }

    // Update is called once per frame
    void Update()
    {
        if(gameObject.name == "Bullet(Clone)" || gameObject.name == "Bullet Cluster(Clone)"){
                transform.Translate(0, 0, 0.5f);
        }
        else if(gameObject.name == "Arrow(Clone)"){
            transform.position += transform.forward;
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
     if(gameObject.name == "Bullet(Clone)" || gameObject.name == "Bullet Cluster(Clone)"){

    
        if(Enemy == null)
        {
            Enemy = GameObject.FindWithTag("Enemy");
        }
        //print("Hooray!!!");

        if (collision.gameObject.CompareTag("Enemy"))
        {
            Ehealth womp = Enemy.GetComponent<Ehealth>();
            Destroy(gameObject);
            Debug.Log("Don't do it! Please!");
            var health = collision.gameObject.GetComponent<Ehealth>();
            if(health != null)
            {
                health.Health -= 10;

                if (womp.Health <= 0)
                {
                    //print("poop");
                    EC.ugh = true;
                        womp.GetComponent<Animator>().SetFloat("locomotion", 0);
                        womp.GetComponent<Animator>().SetBool("isDead", true);
                    Destroy(collision.gameObject, 2);

                }
            }

        }
        if(collision.gameObject.CompareTag("Wall") || collision.gameObject.CompareTag("Floor"))
        {
            Instantiate(BulletHole, gameObject.transform.position, collision.transform.rotation);
             Destroy(gameObject);
        }
     }
    }
}
