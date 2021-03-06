﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;




[System.Serializable]
public class Team : MonoBehaviour
{

    public SaveTeamData data;
    


    [SerializeField] public string playerName;
    [SerializeField] public string TeamName;
    [SerializeField] public int played = 5;
    [SerializeField] public int playerAtk = 10;
    [SerializeField] public int playerDef = 10;
    [SerializeField] public int Pts = 0;
    [SerializeField] public int Gf = 0;
    [SerializeField] public int Ga = 0;
    [SerializeField] public int GD = 0;
    [SerializeField] public bool FormationChanged = false;
    [SerializeField] public int Formation = 3;
    [SerializeField] public int LeaugeTitles = 0;
    [SerializeField] public int cupTitles = 0;
    [SerializeField] public int eCupTitles = 0;
    [SerializeField] public int cCupTitles = 0;
    [SerializeField] public bool cupTeam = true;
    [SerializeField] public bool eCupTeam = false;
    [SerializeField] public bool cCupTeam = false;





    // Start is called before the first frame update
    void Start()
    {
        playerName = "CPU";
        Pts = Random.Range(0, 90);
        
    }

  
    //add data to local variables
    public void AddData()

    {

        data.playerName = playerName;
        data.TeamName = TeamName;
        data.played = played;
        data.playerAtk = playerAtk;
        data.playerDef = playerDef;
        data.Pts = Pts;
        data.Gf = Gf;
        data.Ga = Ga;
        data.GD = GD;
        data.FormationChanged = FormationChanged;
        data.Formation = Formation;
        data.LeaugeTitles = LeaugeTitles;
        data.cupTitles = cupTitles;
        data.eCupTitles = eCupTitles;
        data.cCupTitles = cCupTitles;
        data.cupTeam = cupTeam;
        data.eCupTeam = eCupTeam;
        data.eCupTeam = cCupTeam;
    }

    //Load data from save file
    public void LoadData()

    {
        playerName = data.playerName;
        TeamName = data.TeamName;
        played = data.played;
        playerAtk = data.playerAtk;
        playerDef = data.playerDef;
        Pts = data.Pts;
        Gf = data.Gf;
        Ga = data.Ga;
        GD = data.GD;
        FormationChanged = data.FormationChanged;
        Formation = data.Formation;
        LeaugeTitles = data.LeaugeTitles;
        cupTitles = data.cupTitles;
        eCupTitles = data.eCupTitles;
        cCupTitles = data.cCupTitles;
        cupTeam = data.cupTeam;
        eCupTeam = data.eCupTeam;
        cCupTeam = data.cCupTeam;

    }

   
}
