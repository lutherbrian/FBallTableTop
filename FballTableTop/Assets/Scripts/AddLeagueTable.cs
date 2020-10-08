using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddLeagueTable : MonoBehaviour
{

    public GameObject contentpanel;
    public GameObject Leaguestrip;
    private Vector3 OpenPosition;
    // Start is called before the first frame update
    void Start()
    {
        OpenPosition = new Vector3(0, 0, 0);
        addleaugue();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void addleaugue()
    {
        for (int i = 0; i < 9; i++)
        {
            GameObject newgameObject = (GameObject)Instantiate(Leaguestrip);

            newgameObject.transform.SetParent(contentpanel.transform, false);
        }

    }
}
