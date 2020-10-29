using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManagment : MonoBehaviour
{




    public GameObject TeamPrefab;
    public int numberOfPlayers;
    public int numberOfTeams = 9;

    public string player1Name;
    public string player2Name;
    public string player3Name;
    public string player4Name;
    public string player5Name;
    public string player6Name;

    public string player1Team;
    public string player2Team;
    public string player3Team;
    public string player4Team;
    public string player5Team;
    public string player6Team;

    public int player1Atk;
    public int player2Atk;
    public int player3Atk;
    public int player4Atk;
    public int player5Atk;
    public int player6Atk;

    public int player1Def;
    public int player2Def;
    public int player3Def;
    public int player4Def;
    public int player5Def;
    public int player6Def;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < numberOfTeams; i++)
        {
            GameObject newgameObject = (GameObject)Instantiate(TeamPrefab);
            newgameObject.name = "Team" + i;

        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void PlayerNumber(int x)

    {
        numberOfPlayers = x;

        
      
    }

    public void AddTeams()

    {
        for (int i = 0; i < numberOfPlayers; i++)
        {
            GameObject newgameObject = (GameObject)Instantiate(TeamPrefab);
        

            newgameObject.name = "Team" + i;
            
        }

    }

    public void AddPlayerFormations()

    {



    }
}
