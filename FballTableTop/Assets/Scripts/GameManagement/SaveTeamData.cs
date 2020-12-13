
using UnityEngine;


[System.Serializable]
public class SaveTeamData 
{
    [SerializeField] public string playerName;
    [SerializeField] public string TeamName;
    [SerializeField] public int played;

    [SerializeField] public int playerAtk;
    [SerializeField] public int playerDef;
    [SerializeField] public int Pts;
    [SerializeField] public int Gf;
    [SerializeField] public int Ga;
    [SerializeField] public int GD;
    [SerializeField] public bool FormationChanged;
    [SerializeField] public int Formation;
    [SerializeField] public int LeaugeTitles;
    [SerializeField] public int cupTitles;
    [SerializeField] public int eCupTitles;
    [SerializeField] public int cCupTitles;
    [SerializeField] public bool cupTeam;
    [SerializeField] public bool eCupTeam;
    [SerializeField] public bool cCupTeam;

    public SaveTeamData()

    {


    playerName = " ";
    TeamName = " ";
        played = 5;
    playerAtk = 10;
    playerDef = 10;
    Pts = 0;
    Gf = 0;
    Ga = 0;
    GD = 0;
    FormationChanged = false;
    Formation = 3;
    LeaugeTitles = 0;
    cupTitles = 0;
    eCupTitles = 0;
        cCupTitles = 0;
        cupTeam = true;
    eCupTeam = false;
        cCupTeam = false;

    }



}
