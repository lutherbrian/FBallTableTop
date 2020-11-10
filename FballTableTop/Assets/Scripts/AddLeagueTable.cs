using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Linq;


public class AddLeagueTable : MonoBehaviour
{


    public Transform ammo;

    public GameObject contentpanel;
    public GameObject Leaguestrip;
    public int slotNumber;
    private Vector3 OpenPosition;

    private GameObject newLeagueStrip;

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
      

        for (int i = 0; i < slotNumber; i++)
        {
            
            pitch += .2f;

            yield return new WaitForSeconds(0.1f);
            
            newLeagueStrip = (GameObject)Instantiate(Leaguestrip);
            newLeagueStrip.transform.SetParent(contentpanel.transform, false);
            GameObject Teamobject = GameObject.Find("Team" + i);
            Team teamScript = Teamobject.GetComponent<Team>();

            
            newLeagueStrip.GetComponent<LeaugueSlotsdata>().teamText.text = teamScript.TeamName;
            newLeagueStrip.GetComponent<LeaugueSlotsdata>().played.text = teamScript.played.ToString();
            newLeagueStrip.GetComponent<LeaugueSlotsdata>().points.text = teamScript.Pts.ToString();
            newLeagueStrip.GetComponent<LeaugueSlotsdata>().goalsFor.text = teamScript.Gf.ToString();
            newLeagueStrip.GetComponent<LeaugueSlotsdata>().goalsAgainst.text = teamScript.Ga.ToString();
            newLeagueStrip.GetComponent<LeaugueSlotsdata>().goalDif.text = teamScript.GD.ToString();
            newLeagueStrip.GetComponent<LeaugueSlotsdata>().rank.text = i.ToString();


            



        }

    }

    public void addSlotData()

    {
        

    }






}
