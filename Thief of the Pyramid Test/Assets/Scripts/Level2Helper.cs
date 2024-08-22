using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class Level2Helper : MonoBehaviour
{
    public GameObject spawnersinHall;
    public BreakWalls BW;
    public int totalWallsBroken;
    public int stopHallGen;
    public Material SkyBlack;
    public Material SkyNormal;
    public AudioSource Caller;

    [Header ("Checkpoint thingy")]
    public Scene scene;
    public string SceneName;

    public bool InOrOut;
    public BoolCheck BC;

    public void Awake()
    {
        BC.enabled = true;
    }
    // Start is called before the first frame update
    void Start()
    {

        scene = SceneManager.GetActiveScene();
        SceneName = scene.name;
    }

    // Update is called once per frame
    void Update()
    {
        if(totalWallsBroken == 2)
        {
            spawnersinHall.SetActive(true);
            //Caller.Play();
        }

        if(InOrOut == true){
            RenderSettings.fog = false;
            RenderSettings.skybox = SkyNormal;
        }else{
            RenderSettings.fog = true;
            RenderSettings.skybox = SkyBlack;
        }
    }

    public void RenderOutside(){
        
    }
}
