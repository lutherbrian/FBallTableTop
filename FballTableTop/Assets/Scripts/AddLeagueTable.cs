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
            
            GameObject newgameObject = (GameObject)Instantiate(Leaguestrip);
            newgameObject.transform.SetParent(contentpanel.transform, false);
            //newgameObject.GetComponentInChildren<LeaguePlaceMovement>().pitch = pitch;
            newgameObject.transform.Find("Holder/Data/Points").GetComponent<TMP_Text>().text = "200";

            
            
        }

    }






}
