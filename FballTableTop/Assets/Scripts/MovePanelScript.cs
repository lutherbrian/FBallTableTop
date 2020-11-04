using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MovePanelScript : MonoBehaviour
{

    private GameObject PanelOut;
    public GameObject EndPositionPOUT;
    private float speed = 0.8f;
    public float PanelInDelay = 2.5f;
    public GameObject panelIn;
    public GameObject StartPosition;
    private Vector3 EndPositionPIN;

    public bool multipleplayerPanel = false;
    public GameObject gameManagement;
    
    private int panelAnimations;

    public GameObject PanelToOpen;
    public GameObject maincanvas;
    private Vector3 OpenPosition;




    // Start is called before the first frame update
    void Start()
    {
        PanelOut = this.gameObject;
        EndPositionPIN = new Vector3(0.0f, 0.0f, 0.0f);
        gameManagement = GameObject.FindGameObjectWithTag("GameManager");
        panelAnimations = 1;



       // maincanvas = GameObject.FindGameObjectWithTag("MainCanvas");
       // OpenPosition = new Vector3(-3000, 0, 0);
       // LeanTween.moveLocal(this.gameObject, new Vector3(0, 0, 0), 2f).setEaseInOutBack();
    }

    // Update is called once per frame
    void Update()
    {

    }




    public void MovePanelOut()
    {

        if (multipleplayerPanel == true && panelAnimations != gameManagement.GetComponent<GameManagment>().numberOfPlayers)
        {
            
            PanelOut.LeanMoveLocal(EndPositionPOUT.transform.position, speed).setEaseInOutBack();
            StartCoroutine(BringBackPanel(PanelInDelay));
            panelAnimations++;
        }
        else {

          
            
            PanelOut.LeanMoveLocal(EndPositionPOUT.transform.position, speed).setEaseInOutBack();
            panelAnimations = 0;
            StartCoroutine(AnimatePanelIn(PanelInDelay));
            
        }

    }





    IEnumerator AnimatePanelIn(float Time)

    {
        yield return new WaitForSeconds(0.5f);
        panelIn.SetActive(true);
        PanelOut.SetActive(false);

        panelIn.transform.localPosition = StartPosition.transform.position;



        panelIn.LeanMoveLocal(EndPositionPIN, speed).setEaseInOutBack();
        


    }

    IEnumerator BringBackPanel(float Time)
    {
        yield return new WaitForSeconds(.9f);
        

        PanelOut.transform.localPosition = StartPosition.transform.position;

        PanelOut.LeanMoveLocal(EndPositionPIN, speed).setEaseInOutBack();
    }


    public void CreatePanel()

    {

       // GameObject newgameObject = (GameObject)Instantiate(PanelToOpen);
       // newgameObject.transform.localPosition = OpenPosition;

       // newgameObject.transform.SetParent(maincanvas.transform, false);



    }

}
