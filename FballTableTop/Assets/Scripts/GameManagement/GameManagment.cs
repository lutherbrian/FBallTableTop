using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

[System.Serializable]
public class GameManagment : MonoBehaviour
{




    public GameObject TeamPrefab;
    public int numberOfPlayers;
    public int numberOfTeams = 9;
    public int Season = 1;


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
