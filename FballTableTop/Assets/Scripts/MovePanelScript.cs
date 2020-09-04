using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MovePanelScript : MonoBehaviour
{

    private GameObject PanelOut;
    public GameObject EndPositionPOUT;
    private float speed = 0.8f;
    public float PanelInDelay = 0.0f;
    public GameObject panelIn;
    public GameObject StartPosition;
    private Vector3 EndPositionPIN;

    public bool multipleplayerPanel = false;
    public GameObject gameManagement;
    private int panelAnimations;


   
    // Start is called before the first frame update
    void Start()
    {
        PanelOut = this.gameObject;
        EndPositionPIN = new Vector3(0.0f, 0.0f, 0.0f);
        gameManagement = GameObject.FindGameObjectWithTag("GameManager");
        panelAnimations = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }




    public void MovePanelOut()
    {

        if (multipleplayerPanel == true && panelAnimations!= gameManagement.GetComponent<GameManagment>().numberOfPlayers)
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
        yield return new WaitForSeconds(Time);

        panelIn.transform.localPosition = StartPosition.transform.position;



        panelIn.LeanMoveLocal(EndPositionPIN, speed).setEaseInOutBack();


    }

    IEnumerator BringBackPanel(float Time)
    {
        yield return new WaitForSeconds(Time);

        PanelOut.transform.localPosition = StartPosition.transform.position;

        PanelOut.LeanMoveLocal(EndPositionPIN, speed).setEaseInOutBack();
    }
}
