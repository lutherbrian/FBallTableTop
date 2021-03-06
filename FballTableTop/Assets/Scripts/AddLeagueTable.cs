﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Linq;


public class AddLeagueTable : MonoBehaviour
{

    public GameObject contentpanel;
    public GameObject Leaguestrip;
    public int slotNumber;
    private Vector3 OpenPosition;
    private int positionNumber = 1;

    private GameObject newLeagueStrip;
    float pitch = 1;


    // Start is called before the first frame update
    void Start()
    {

        OpenPosition = new Vector3(0, 0, 0);
        StartCoroutine(addleaugue());
    }

 

   IEnumerator addleaugue()
    {

        GameObject gamemanager = GameObject.Find("GameManager");

        SavingLoading teaminfo = gamemanager.GetComponent<SavingLoading>();

        teaminfo.StartSort();

        for (int i = 0; i < slotNumber; i++)
        {
            
            pitch += .2f;

            yield return new WaitForSeconds(0.3f);
            
            newLeagueStrip = (GameObject)Instantiate(Leaguestrip);
            newLeagueStrip.transform.SetParent(contentpanel.transform, false);
            newLeagueStrip.GetComponent<LeaugueSlotsdata>().teamText.text = teaminfo.teamsList[i].TeamName;
            newLeagueStrip.GetComponent<LeaugueSlotsdata>().played.text = teaminfo.teamsList[i].played.ToString();
            newLeagueStrip.GetComponent<LeaugueSlotsdata>().points.text = teaminfo.teamsList[i].Pts.ToString();
            newLeagueStrip.GetComponent<LeaugueSlotsdata>().goalsFor.text = teaminfo.teamsList[i].Gf.ToString();
            newLeagueStrip.GetComponent<LeaugueSlotsdata>().goalsAgainst.text = teaminfo.teamsList[i].Ga.ToString();
            newLeagueStrip.GetComponent<LeaugueSlotsdata>().goalDif.text = teaminfo.teamsList[i].GD.ToString();
            newLeagueStrip.GetComponent<LeaugueSlotsdata>().rank.text = positionNumber.ToString();
            positionNumber++;

            if (teaminfo.teamsList[i].playerName.Contains("Computer"))
            {

                newLeagueStrip.GetComponent<LeaugueSlotsdata>().Icon.SetActive(false);
            }

           


            



        }

    }

    public void addSlotData()

    {
        

    }






}
