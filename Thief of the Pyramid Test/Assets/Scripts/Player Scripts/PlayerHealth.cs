using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public int MaxHealth;
    public int phealth;
    public GameObject Player;
    public GameObject Enemy;
    public GameObject Ehitbox;
    public GameObject HCount;
    public int healsLeft;
    
    public Text HText;
    public Text healcound;


    public EnemyAttack EA;
    public BoolCheck BC;

    public bool isAttackable;
    public int Iframetime;
    // Start is called before the first frame update
    void Start()
    {
        MaxHealth = 100;
        healsLeft = 3;
        phealth = MaxHealth;
        isAttackable = true;
        Iframetime = 3;
        Enemy = GameObject.FindGameObjectWithTag("Enemy");
        Ehitbox = GameObject.FindGameObjectWithTag("EBox");
    }

    // Update is called once per frame
    void Update()
    {
        if (phealth <= 0)
        {
            BC.GameOver();
        }
        HText.text = phealth.ToString();
        healcound.text = healsLeft.ToString();
        if (phealth > MaxHealth)
        {
            phealth = MaxHealth;
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            Debug.LogError("I HAVE PRESSED F");
            if (healsLeft > 0)
            {
                phealth += 50;
                healsLeft -= 1;
                healcound.text = healsLeft.ToString();
            }
        }
     
       // Ehitbox = GameObject.FindGameObjectWithTag("EBox");
      //  EnemyAttack EA = Ehitbox.GetComponent<EnemyAttack>();






      //  if(EA.attackon == true){
        //Invoke("Iframes",0);
       // }
    }

    //public void Iframes(){
        //Ehitbox=GameObject.FindGameObjectWithTag("EBox");
        //EnemyAttack EA = Ehitbox.GetComponent<EnemyAttack>();
        //EA.attackon = false;
        //isAttackable = false;
        //Invoke("Again", Iframetime);
    //}

    //public void Again()
    //{
        //isAttackable = true;
    //}
    
}
