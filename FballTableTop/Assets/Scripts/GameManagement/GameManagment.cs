using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

[System.Serializable]
public class GameManagment : MonoBehaviour
{


    [SerializeField] public GameManagementData data;

    [SerializeField] public GameObject TeamPrefab;
    [SerializeField] public int numberOfPlayers;
    [SerializeField] public int numberOfTeams = 9;
    [SerializeField] public int Season = 1;
    [SerializeField] public int Week = 1;
    [SerializeField] public int ffCupRound = 1;
    [SerializeField] public int eCupRound = 1;
    [SerializeField] public int uCupRound = 1;
    [SerializeField] public int cCupRound = 1;

    [SerializeField] public int currentPanel = 0;


    [SerializeField] public TMP_InputField Team1;
    [SerializeField] public TMP_InputField Team2;
    [SerializeField] public TMP_InputField Team3;
    [SerializeField] public TMP_InputField Team4;
    [SerializeField] public TMP_InputField Team5;
    [SerializeField] public TMP_InputField Team6;
    [SerializeField] public TMP_InputField Team7;
    [SerializeField] public TMP_InputField Team8;
    [SerializeField] public TMP_InputField Team9;
    [SerializeField] public TMP_InputField Team10;
    [SerializeField] public TMP_InputField Team11;
    [SerializeField] public TMP_InputField Team12;
    [SerializeField] public TMP_InputField Team13;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < numberOfTeams; i++)
        {
            GameObject newgameObject = (GameObject)Instantiate(TeamPrefab);
            newgameObject.name = "Team" + i;

        }
    }

   

    public void PlayerNumber(int x)

    {
        numberOfPlayers = x;

        
      
    }
    //ADD TEAMS BASED ON NUMBER OF PLAYERS
    public void AddTeams()

    {
        for (int i = 0; i < numberOfPlayers; i++)
        {
            GameObject newgameObject = (GameObject)Instantiate(TeamPrefab);
        

            newgameObject.name = "Team" + i;
            
        }

    }
    //ADD DATA FROM GAMEMANAGEMENT DATA
    public void addData()

    {
        data.Team1 = Team1.text;


        data.numberOfPlayers = numberOfPlayers;
        data.numberOfTeams = numberOfTeams;
        data.Season = Season;
        data.Week = Week;
        data.currentPanel = currentPanel;
        data.ffCupRound = ffCupRound;
        data.eCupRound = eCupRound;
        data.uCupRound = uCupRound;
        data.cCupRound = cCupRound;


        data.Team1 = Team1.text;
        data.Team2 = Team2.text;
        data.Team3 = Team3.text;
        data.Team4 = Team4.text;
        data.Team5 = Team5.text;
        data.Team6 = Team6.text;
        data.Team7 = Team7.text;
        data.Team8 = Team8.text;
        data.Team9 = Team9.text;
        data.Team10 = Team10.text;
        data.Team11 = Team11.text;
        data.Team12 = Team12.text;
        data.Team13 = Team13.text;

    }
    //LOAD DATA FROM SAVE FILE
    public void LoadData()

    {
        data.Team1 = Team1.text;


        numberOfPlayers = data.numberOfPlayers;
        numberOfTeams = data.numberOfTeams;
        Season = data.Season;
        Week = data.Season;
        currentPanel = data.currentPanel;
        ffCupRound = data.ffCupRound;
        eCupRound = data.eCupRound;
        uCupRound = data.uCupRound;
        cCupRound = data.cCupRound;


    Team1.text = data.Team1;
        Team2.text = data.Team2;
        Team3.text = data.Team3;
        Team4.text = data.Team4;
        Team5.text = data.Team5;
        Team6.text = data.Team6;
        Team7.text = data.Team7;
        Team8.text = data.Team8;
        Team9.text = data.Team9;
        Team10.text = data.Team10;
        Team11.text = data.Team11;
        Team12.text = data.Team12;
        Team13.text = data.Team13;
        

    }
    //ADD WEEKS TO COUNTER
    public void addweek()

    {
        Week++;

        if (Week == 12)

        {

            Season++;
            Week = 0;
        }

    }

    
   
}
