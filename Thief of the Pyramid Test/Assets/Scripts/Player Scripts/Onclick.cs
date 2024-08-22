using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Onclick : MonoBehaviour
{
    [Header("Game Objects")]
    public GameObject TitleScreen;
    public GameObject OptionScreen;
    public GameObject LScreen;
    public GameObject OpButton;
    public GameObject ConSet;
    public GameObject Credits;
    public GameObject HELDER;

    [Header("Animations")]
    public Animation cardSwoop;
    public Animation clearOut;
    public Animation stopGrowing;

    public Scene scene;
    public string SceneName;
    // Start is called before the first frame update

    public void Awake()
    {
        Cursor.lockState = CursorLockMode.None;
        print(Cursor.lockState);
        Credits.SetActive(false);
        clearOut.Stop();
        cardSwoop.Stop();
        TitleScreen.SetActive(true);
        OptionScreen.SetActive(false);
    }
    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        scene = SceneManager.GetActiveScene();
        SceneName = scene.name;
        if(SceneName == "Menu")
        {
            LScreen.SetActive(false);
            clearOut.Stop();
            cardSwoop.Stop();
        }

    }

    // Update is called once per frame
    void Update()
    {


    }

    public void OnMenuClicked()
    {
        SceneManager.LoadScene(0);
    }

    public void OnExitClicked()
    {
        Application.Quit();
    }

    public void OnPlayClick()
    {
        LScreen.SetActive(true);
        clearOut.Play();
        cardSwoop.Play();
        Invoke("theFunnyScene", 3f);

    }

    public void theFunnyScene()
    {
        SceneManager.LoadScene(1);
    }

    public void OnOptionClick()
    {
        OptionScreen.SetActive(true);
        OpButton.SetActive(false);
        ConSet.SetActive(false);
        TitleScreen.SetActive(false);
        Invoke("InvokeButtonEnable", 1.8f);
    }

    public void OnBackClicked()
    {
        TitleScreen.SetActive(true);
        OptionScreen.SetActive(false);
        Credits.SetActive(false);
    }

    //Use this for now, find a better solution later.
    public void InvokeButtonEnable()
    {
        stopGrowing.Stop();
        OpButton.SetActive(true);
        ConSet.SetActive(true);
    }

    public void OnCreditsClicked()
    {
        TitleScreen.SetActive(false);
        Credits.SetActive(true);
        HELDER.SetActive(false);
        Invoke("CreditsRoll", 1.8f);
    }

    public void CreditsRoll()
    {
        stopGrowing.Stop();
        HELDER.SetActive(true);
    }
}
