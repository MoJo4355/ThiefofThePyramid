using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turnon : MonoBehaviour
{
    public BoolCheck BC;
    public PickUp Picks;

    public GameObject Me;
    public GameObject Torch;
    public GameObject door1;
    public GameObject doorLight;
    public Animation doorGoUp;
// Ill try to use this script to act as the manager for the first level(tutorial)
    void Start()
    {
        door1.SetActive(true);
        doorGoUp.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        if(BC.enlightened == true)
        {
            Me.SetActive(true);
        }

        if (BC.TorchHelp == true)
        {
            Destroy(Torch.gameObject);
        }

        if (Picks.TheDoorisOpen == true)
        {
            doorLight.SetActive(true);
            Destroy(door1);
        }
    }
}
