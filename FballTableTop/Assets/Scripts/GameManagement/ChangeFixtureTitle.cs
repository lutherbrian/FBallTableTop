using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ChangeFixtureTitle : MonoBehaviour
{
    
    public TextMeshProUGUI Title;

    public bool FFCup = false;
    public bool eCup = false;
    public bool uCup = false;
    public bool cCup = false;
    public bool league = false;
    
    
    private GameManagment Gamemanager;
    private GameObject Team;
    // Start is called before the first frame update
    void Start()
    {

        Gamemanager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManagment>();


      
        ChangeTitle();

    }

    // Update is called once per frame
    void Update()
    {

    }

    // changes the title of the panel based on what fixture is being played
    public void ChangeTitle()
    {
        if (league == false)

        {

            if (FFCup == true)
            {

                Title.text = "Round - " + Gamemanager.ffCupRound + " Football Fortunes Cup";
                Gamemanager.ffCupRound++;
                Debug.Log("Test");
            }


            if (eCup == true)
            {

                Title.text = "Round - " + Gamemanager.eCupRound + " European Cup Fixtures";
                Gamemanager.eCupRound++;
            }

            if (uCup == true)
            {

                Title.text = "Round - " + Gamemanager.uCupRound + " U Cup Fixtures";
                Gamemanager.uCupRound++;
            }

            if (cCup == true)
            {

                Title.text = "Round - " + Gamemanager.cCupRound + " Clough Cup";
                Gamemanager.cCupRound++;
            }

        }
        

        else
        {

            

                Title.text = "Week- " + Gamemanager.Week + " League Fixtures";
            
        }

    }


}
