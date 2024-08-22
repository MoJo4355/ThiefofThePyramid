using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelOneTriggers : MonoBehaviour
{
    public GameObject TreasureWallTrap;
    public GameObject Player;
    
    [Header("Scripts")]
    public PickUp pick;
    public PlayerMovement PM;
    public AudioSource PW;

    [Header("Cat Puzzle")]
    public GameObject UnTranslatedTablet;
    public GameObject TranslatedTablet;
    public GameObject Misc;
    public GameObject SecretDoorToTreasure;
    public GameObject THEROSETTASTONE;
    public GameObject Up;
    public GameObject Down;
    public GameObject Gate;

    [Header("Final Hallway")]
    public GameObject Curse;
    public GameObject Standingcats;
    public GameObject FallenCats;
    public GameObject Blockades;
    public GameObject Stair;
    public GameObject Side;
    public GameObject TrappedT;
    public GameObject Exit;
    public GameObject WalllDestroy;
    public GameObject Torches;
    public Text Run;
    public bool WakeUp;

    public Animation Reveal;
    public Animation RunColor;
    public GameObject HiddenCamforDating;

    public bool TWTrapAction;
    public bool TWTrapEnemy;
    // Start is called before the first frame update
    public void Awake()
    {
        Run.enabled = false;
    }

    void Start()
    {
        THEROSETTASTONE.SetActive(false);
        HiddenCamforDating.SetActive(false);
        Reveal.Stop();
        SecretDoorToTreasure.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if(pick.TreasureTrapActive == true)
        {
            print("This happened also");
            Invoke("OnTreasureWallTriggered", 0.1f);
        }

        if (pick.CatPuzHelp == true)
        {
            if(pick.Translated == false)
            {
                Misc.SetActive(true);
                TranslatedTablet.SetActive(false);
                UnTranslatedTablet.SetActive(true);

                pick.CatPuzHelp = false;
            }
            else
            {
                Misc.SetActive(true);
                TranslatedTablet.SetActive(true);
                UnTranslatedTablet.SetActive(false);
                THEROSETTASTONE.SetActive(true);
                pick.CatPuzHelp = false;
            }

        }

        if(pick.Translated == true)
        {
            THEROSETTASTONE.SetActive(true);
        }

        if(pick.Inorder == 7)
        {
            Reveal.Play();
            HiddenCamforDating.SetActive(true);
            Player.SetActive(false);
            Invoke("stopanimating", 3.0f);
        }

        if(pick.levelflip == false)
        {
            Up.SetActive(true);
            Down.SetActive(false);
            Gate.SetActive(true);
        }
        else
        {
            Down.SetActive(true);
            Up.SetActive(false);
            Gate.SetActive(false);
        }

        if (pick.RunTrigger == true)
        {
            PW.enabled = false;
            Curse.SetActive(true);
            Run.enabled = true;
            Standingcats.SetActive(false);
            FallenCats.SetActive(true);
            Blockades.SetActive(true);
            Stair.SetActive(false);
            Side.SetActive(false);
            TrappedT.SetActive(false);
            PM.moveSpeed = 12;
            Exit.SetActive(true);
            Destroy(WalllDestroy.gameObject);
            Torches.SetActive(false);
            WakeUp = true;
        }
    }

    public void OnTreasureWallTriggered()
    {
        print("did it yay");
        TreasureWallTrap.SetActive(false);
        TWTrapEnemy = true;
    }
    public void stopanimating()
    {
        Player.SetActive(true);
        HiddenCamforDating.SetActive(false);
        SecretDoorToTreasure.SetActive(false);
        pick.Inorder = 0;
    }
}
