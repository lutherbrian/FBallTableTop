using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

[System.Serializable]
public class SavingLoading : MonoBehaviour
{


    [SerializeField] public List<Team> teamsList = new List<Team>();
    [SerializeField] public List<SaveTeamData> teamSaveData = new List<SaveTeamData>();
    
    [SerializeField] public List<GameManagementData> gMSaveData = new List<GameManagementData>();

    public List<SaveTeamData> teamLoadedData = new List<SaveTeamData>();
    






    private int loop = 0;
    // Start is called before the first frame update
    void Start()
    {
        LeanTween.delayedCall(this.gameObject, 2f, (addTeamsToList));
        LeanTween.delayedCall(this.gameObject, 2f, (AutoSave));
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))

        {
            StartSort();

        }
    }

    public void addTeamsToList()

    {
        for (int i = 0; i < 9; i++)
        {
            Team Teamobject = GameObject.Find("Team" + i).GetComponent<Team>();

            teamsList.Add(Teamobject);
            loop++;

        }




    }


    [ContextMenu("SaveTest")]
    public void addSaveData()

    {
        teamSaveData.Clear();
        gMSaveData.Clear();
        for (int i = 0; i < 9; i++)
        {
            Team Teamobject = GameObject.Find("Team" + i).GetComponent<Team>();
            Teamobject.AddData();
            SaveTeamData data = Teamobject.data;
            teamSaveData.Add(data);

            Debug.Log("savingTD");

            if (i == 8)

            {
                Debug.Log("savingGM");
                this.gameObject.GetComponent<GameManagment>().addData();
                gMSaveData.Add(this.gameObject.GetComponent<GameManagment>().data);
                SaveTeams();
                SaveGMData();

            }

        }

        


    }



    public void StartSort()

    {

        teamsList.Sort(SortList);
    }

    public int SortList(Team a, Team b)

    {

        if (a.Pts < b.Pts)

        {

            return 1;
        }

        else if (a.Pts > b.Pts)

        {

            return -1;
        }

        return 0;
    }


    public void SaveTeams()

    {

        
        BinaryFormatter binary = new BinaryFormatter();
        FileStream fStream = File.Create(Application.persistentDataPath + "/TeamData.FBF");
        binary.Serialize(fStream, teamSaveData);
        fStream.Close();
    }

  



    public void LoadTeamFile()
    {
        if (File.Exists(Application.persistentDataPath + "/TeamData.FBF"))
        {
            using (Stream stream = File.Open(Application.persistentDataPath + "/TeamData.FBF", FileMode.Open))
            {
                var bformatter = new BinaryFormatter();

                teamLoadedData = (List<SaveTeamData>)bformatter.Deserialize(stream);

                
                applySaveData();
            }

        }
    }


    public void SaveGMData()

    {
        BinaryFormatter binary = new BinaryFormatter();
        FileStream fStream = File.Create(Application.persistentDataPath + "/GMData.FBF");
        binary.Serialize(fStream, gMSaveData);
        fStream.Close();


    }



    public void LoadGMFile()
    {
        if (File.Exists(Application.persistentDataPath + "/GMData.FBF"))
        {
            using (Stream stream = File.Open(Application.persistentDataPath + "/GMData.FBF", FileMode.Open))
            {
                var bformatter = new BinaryFormatter();

                gMSaveData = (List<GameManagementData>)bformatter.Deserialize(stream);

                this.gameObject.GetComponent<GameManagment>().data = gMSaveData[0];
                this.gameObject.GetComponent<GameManagment>().LoadData();
                this.gameObject.GetComponent<LoadPanel>().panelNumber = gMSaveData[0].currentPanel;

                this.gameObject.GetComponent<LoadPanel>().MoveStartScreen();
                


            }

        }
    }


    public void applySaveData()

    {
        Debug.Log("Loaded");
        for (int i = 0; i < teamLoadedData.Count; i++)
        {
            Team nTeam = GameObject.Find("Team" + i).GetComponent<Team>();

            nTeam.data = teamLoadedData[i];
            nTeam.LoadData();
            



        }
    }


   void AutoSave()

    {
       //addSaveData();
       //LeanTween.delayedCall(this.gameObject, 2f, (AutoSave));

    }

   


}
