using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManagment : MonoBehaviour
{
    
    public struct Player1
    {

        public string   playerName1;
        public string   playerTeam1;
        public int      playerAtk1;
        public int      playerDef1;
        public int      Pts1;
        public int      Gf1;
        public int      Ga1;
        public int      GD;


    }

    public int numberOfPlayers;

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
       
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void PlayerNumber(int x)

    {
        numberOfPlayers = x;

        
      
    }
}
