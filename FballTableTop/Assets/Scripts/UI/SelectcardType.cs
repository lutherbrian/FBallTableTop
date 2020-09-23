using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectcardType : MonoBehaviour
{

    public GameObject PanelToOpen;
    public GameObject maincanvas;
    private Vector3 OpenPosition;

    // Start is called before the first frame update
    void Start()
    {
        maincanvas = GameObject.FindGameObjectWithTag("MainCanvas");
        OpenPosition = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void openPanel()

    {

        GameObject newgameObject = (GameObject)Instantiate(PanelToOpen);
        
        newgameObject.transform.SetParent(maincanvas.transform, false);

        

    }
}
