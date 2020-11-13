using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SavingLoading : MonoBehaviour
{
    

    public List<Team> teams = new List<Team>();

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

            teams.Add(Teamobject);
            loop++;
            
        }

      
        

    }

   

    public void StartSort()

    {

        teams.Sort(SortList);
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

   
}
