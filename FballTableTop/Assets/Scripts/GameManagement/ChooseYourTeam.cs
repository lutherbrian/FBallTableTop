﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using TMPro;

public class ChooseYourTeam : MonoBehaviour
{

    public GameObject gameManger;
    public GameManagment gamemanagementScript;
    public TMP_Dropdown dropdown;
    public TMP_InputField inputfield;
    private int numberofPlayers;

    public TMP_InputField Team1;
    public TMP_InputField Team2;
    public TMP_InputField Team3;
    public TMP_InputField Team4;
    public TMP_InputField Team5;
    public TMP_InputField Team6;
    public TMP_InputField Team7;
    public TMP_InputField Team8;
    public TMP_InputField Team9;
    public TMP_InputField Team10;
    public TMP_InputField Team11;
    public TMP_InputField Team12;
    public TMP_InputField Team13;

   
    private int PlayerNUM = 0;
    private GameObject Team;
    // Start is called before the first frame update


    void Start()
    {

        gamemanagementScript = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManagment>();
        gameManger = GameObject.FindGameObjectWithTag("GameManager");


        addDropOptions();
        
        numberofPlayers = gamemanagementScript.numberOfPlayers;
        List<string> m_DropOptions = new List<string> { Team1.text, Team2.text, Team3.text, Team4.text, Team5.text, Team6.text, Team7.text, Team8.text, Team9.text, Team10.text, Team11.text, Team12.text, Team13.text };
        dropdown.ClearOptions();
        dropdown.AddOptions(m_DropOptions);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void addDropOptions()

    {
        Team1 = gamemanagementScript.Team1;
        Team2 = gamemanagementScript.Team2;
        Team3 = gamemanagementScript.Team3;
        Team4 = gamemanagementScript.Team4;
        Team5 = gamemanagementScript.Team5;
        Team6 = gamemanagementScript.Team6;
        Team7 = gamemanagementScript.Team7;
        Team8 = gamemanagementScript.Team8;
        Team9 = gamemanagementScript.Team9;
        Team10 = gamemanagementScript.Team10;
        Team11 = gamemanagementScript.Team11;
        Team12 = gamemanagementScript.Team12;
        Team13 = gamemanagementScript.Team13;

        List<string> m_DropOptions = new List<string> { Team1.text, Team2.text, Team3.text, Team4.text, Team5.text, Team6.text, Team7.text, Team8.text, Team9.text, Team10.text, Team11.text, Team12.text, Team13.text };
        dropdown.ClearOptions();
        dropdown.AddOptions(m_DropOptions);
    }

    public void AddPlayer()
    {
        
                Team = GameObject.Find("Team"+PlayerNUM);
                Team.GetComponent<Team>().playerName = inputfield.text;
                Team.GetComponent<Team>().TeamName = dropdown.options[dropdown.value].text;
                dropdown.options.RemoveAt(dropdown.value);
                dropdown.value = dropdown.value + 1;
                dropdown.value = 0;

                inputfield.text = "";

                PlayerNUM++;
        // set the rest of the computer team names
        if (PlayerNUM > numberofPlayers - 1)

        {
            
            for (int i = numberofPlayers; i < 9; i++)
            {
                
                Team = GameObject.Find("Team" + i);
                Team.GetComponent<Team>().TeamName = dropdown.options[dropdown.value].text;
                dropdown.options.RemoveAt(dropdown.value);
                dropdown.value = dropdown.value + 1;
                dropdown.value = 0;

                Team.GetComponent<Team>().playerName = "Computer"+ (i - numberofPlayers);

            }

        }
             


    }

    public void AddCTeam()

    {

      


    }


}
