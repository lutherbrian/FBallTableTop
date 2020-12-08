using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddManagerRatings : MonoBehaviour
{

    public GameObject contentpanel;
    public GameObject RatingsStrip;
    private int Rank = 1;
    private Vector3 OpenPosition;
    private int positionNumber = 1;

    private GameObject newRatingsStrip;

    float pitch = 1;
    // Start is called before the first frame update
    void Start()
    {

        OpenPosition = new Vector3(0, 0, 0);
        StartCoroutine(addleaugue());
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator addleaugue()
    {

        GameObject gamemanager = GameObject.Find("GameManager");

        

       

        for (int i = 0; i < gamemanager.GetComponent<GameManagment>().numberOfPlayers; i++)
        {

            pitch += .2f;

            yield return new WaitForSeconds(0.3f);

            GameObject teaminfo = GameObject.Find("Team"+i);

            newRatingsStrip = (GameObject)Instantiate(RatingsStrip);
            newRatingsStrip.transform.SetParent(contentpanel.transform, false);

            newRatingsStrip.GetComponent<LeaugueSlotsdata>().teamText.text = teaminfo.GetComponent<Team>().TeamName;
            newRatingsStrip.GetComponent<LeaugueSlotsdata>().played.text = teaminfo.GetComponent<Team>().LeaugeTitles.ToString();
            newRatingsStrip.GetComponent<LeaugueSlotsdata>().won.text = teaminfo.GetComponent<Team>().cupTitles.ToString();
            newRatingsStrip.GetComponent<LeaugueSlotsdata>().Lost.text = teaminfo.GetComponent<Team>().eCupTitles.ToString();
            newRatingsStrip.GetComponent<LeaugueSlotsdata>().goalsFor.text = (teaminfo.GetComponent<Team>().eCupTitles + teaminfo.GetComponent<Team>().cupTitles + teaminfo.GetComponent<Team>().LeaugeTitles).ToString();
            newRatingsStrip.GetComponent<LeaugueSlotsdata>().rank.text = Rank.ToString();
            Rank++;









        }

    }

  





}

