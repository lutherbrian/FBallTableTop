using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddFixtures : MonoBehaviour
{
    public GameObject contentpanel;
    public GameObject Fixturestrip;
    public int slotNumber;
    private Vector3 OpenPosition;

    private GameObject newFixtureStrip;

    float pitch = 1;
    // Start is called before the first frame update
    void Start()
    {

        OpenPosition = new Vector3(0, 0, 0);
        StartCoroutine(addFixtureSlot());
    }

  
    //adds fixture slots, number is based on the slot number
    IEnumerator addFixtureSlot()
    {


        for (int i = 0; i < slotNumber; i++)
        {
            
            pitch += .2f;

            yield return new WaitForSeconds(0.3f);

            newFixtureStrip = (GameObject)Instantiate(Fixturestrip);
            newFixtureStrip.transform.SetParent(contentpanel.transform, false);
     

        }

    }
}
