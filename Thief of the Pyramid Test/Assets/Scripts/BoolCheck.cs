using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BoolCheck : MonoBehaviour
{
    [Header("Key scripts")]
    public GetKey getkey;
    public bool DoorUnlock;
    public bool Keyuse;
    public bool EnemyNavEnable;
    public bool enlightened;

    [Header("Treasure Scripts")]
    public bool Pickup;

    [Header("enemy death")]
    public AudioSource Caller;
    public int GlobalEnemyCount;
    public bool DoorRaise;
    public bool Ronald;
    public bool Finaler;
    public bool lastHall;
    //public EnemyCheck EC;
    public GameObject door;
    public bool happygilmore;

    [Header("Hearts")]
    public GameObject[] hortes;
    public int eyespy;

    [Header("PAUSE MENU")]
    public GameObject Player;
    public GameObject Pause;
    public GameObject PAUSEDCAMERA;
    public GameObject CamMove;
    public bool DISABLE;

    public int შვედურიმეტროსსისტემა;
    public GameObject getthefinalkey;
    public bool finaldooropen;

    public bool TorchHelp;
    public bool deathHelp;
    public Attack AK;
    public GameObject GameOverCanvas;

    [Header("Respawn at Checkpoint")]
    public int l2triggered;
    public int l2check;
    public GameObject dummy;
    public Scene scene;
    public string SceneName;
    // Start is called before the first frame update

    void Awake()
    {
        GameOverCanvas.SetActive(false);
    }
    void Start()
    {
        l2check = PlayerPrefs.GetInt("Level2");
        scene = SceneManager.GetActiveScene();
        SceneName = scene.name;
        Finaler = false;
        DoorUnlock = false;
        Pickup = false;
        Keyuse = false;
        DoorRaise = false;
        Ronald = true;
        EnemyNavEnable = false;
        deathHelp = false;

        eyespy = 3;
        GameOverCanvas.SetActive(false);


        if (SceneName == "Level 2")
        {
            if (l2triggered == 0 && l2check == 0)
            {
                l2triggered += 1;
                PlayerPrefs.SetInt("Level2", 1);
                print("booyeah!");
            }
            else
            {
                print("Aw shucks");
            }


        }

    }

    // Update is called once per frame
    void Update()
    {
        GlobalEnemyCount = GameObject.FindGameObjectsWithTag("Enemy").Length;
        //note:
        //Every time GEC > 0, make enemy song play, else make normal song play;)

        if(GlobalEnemyCount == 0 && lastHall == true && happygilmore == false)
        {
            Vector3 down = new Vector3(0, -1, 0);
            GameObject finalkey = Instantiate(getthefinalkey, Player.transform.position + Vector3.forward + down, Player.transform.rotation) as GameObject;
            happygilmore = true;
        }
        GlobalEnemyCount = GameObject.FindGameObjectsWithTag("Enemy").Length;
        if (GlobalEnemyCount > 0)
        {
        }
    }

    void Tralalalala()
    {
        door.SetActive(false);
    }

   


    public void ONRetryClicked()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void OnMenuClicked()
    {
        SceneManager.LoadScene(0);
    }

    public void GameOver(){
                
            Cursor.lockState = CursorLockMode.None;
            GameOverCanvas.SetActive(true);
            AK.enabled = false;
            Cursor.lockState = CursorLockMode.None;
            deathHelp = true;
            PAUSEDCAMERA.SetActive(true);
            CamMove.SetActive(false);
    }
    /// <lol>
    /// this is super funni
    /// </get recked>
    /// 
    
    public void RespawnAtCheckpoint()
    {
        if(dummy == null){
            dummy = GameObject.FindWithTag("Respawn");
            Debug.Log(dummy);
        }
        Destroy(Player);
        Cursor.lockState = CursorLockMode.Locked;
        GameOverCanvas.SetActive(false);
        AK.enabled = true;
        Cursor.lockState = CursorLockMode.Locked;
        deathHelp = false;
        PAUSEDCAMERA.SetActive(false);
        CamMove.SetActive(true);
        Instantiate(Player, dummy.transform.position, dummy.transform.rotation);
    }
}

