using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ChangetitleNames : MonoBehaviour
{
    public int PlayerNum;

    public TextMeshProUGUI playerinfo;
   
    private GameManagment Gamemanager;
    private GameObject Team;
    // Start is called before the first frame update
    void Start()
    {

        Gamemanager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManagment>();


        PlayerNum = 0;
        ChangeTitle();
        
    }

    // Update is called once per frame
    void Update()
    {

    }


    public void ChangeTitle()
    {


      


        if (PlayerNum != Gamemanager.numberOfPlayers)
        {
            Team = GameObject.Find("Team"+PlayerNum);
            playerinfo.text = Team.GetComponent<Team>().playerName + " - " + Team.GetComponent<Team>().TeamName;

          

            PlayerNum++;
        }

        else
        {

            PlayerNum = 0;
            Team = GameObject.Find("Team" + PlayerNum);
            playerinfo.text = Team.GetComponent<Team>().playerName + " - " + Team.GetComponent<Team>().TeamName;



            PlayerNum++;
        }

    }

    
}
