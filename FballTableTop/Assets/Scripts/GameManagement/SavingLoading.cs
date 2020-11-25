using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

[System.Serializable]
public class SavingLoading : MonoBehaviour
{


    [SerializeField] public List<Team> teamsList = new List<Team>();
    [SerializeField] public List<SaveTeamData> SaveData = new List<SaveTeamData>();
    public List<SaveTeamData> SaveData2 = new List<SaveTeamData>();






    private int loop = 0;
    // Start is called before the first frame update
    void Start()
    {
        LeanTween.delayedCall(this.gameObject, 2f, (addTeamsToList));
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


    [ContextMenu("Do Something")]
    public void adddata()

    {
        for (int i = 0; i < 9; i++)
        {
            SaveTeamData data = GameObject.Find("Team" + i).GetComponent<Team>().data;

            SaveData.Add(data);
            loop++;

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



        binary.Serialize(fStream, SaveData);
        fStream.Close();
    }



    public void LoadFile()
    {
        if (File.Exists(Application.persistentDataPath + "/TeamData.FBF"))
        {
            using (Stream stream = File.Open(Application.persistentDataPath + "/TeamData.FBF", FileMode.Open))
            {
                var bformatter = new BinaryFormatter();

                List<SaveTeamData> items = (List<SaveTeamData>)bformatter.Deserialize(stream);

                SaveData2 = items;
                //applySaveData();
            }

        }
    }


    public void applySaveData()

    {
        for (int i = 0; i < teamsList.Count; i++)
        {
            Team nTeam = GameObject.Find("Team" + i).GetComponent<Team>();

            //nTeam = SaveData[i];



        }
    }


   

   


}
