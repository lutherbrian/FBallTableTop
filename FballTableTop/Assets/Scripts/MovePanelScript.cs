﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MovePanelScript : MonoBehaviour
{

    
    
    private float speed = 0.8f;
    public float PanelInDelay = 2.5f;
    public int panelnumber;
    public bool multipleplayerPanel = false;
    public bool spawn = true;
    public bool saveGame = true;
    public bool addweek = false;
    public bool showCupTransfers = false;
    public bool ShowTransfers = false;
    private int panelAnimations;
    public GameObject PanelToOpen;
    public GameObject cupPanel;
    public GameObject transfersPanel;
    public GameObject CcupPanel;
    public GameObject EcupPanel;
    public GameObject UcupPanel;
    public GameObject youWonPanel;
    private GameObject maincanvas;
    private Vector3 OpenPosition;
    private GameManagment gameManagement;
    private GameObject gameManagementObj;
    

    
    void Start()
    {
        
        //Find the GameManager Object and get the GameManagement Script
        gameManagementObj = GameObject.FindGameObjectWithTag("GameManager");
        gameManagement = gameManagementObj.GetComponent<GameManagment>();


        //only change the panel number if is not set to 20. Means the game won't load into certain panels. 
        if (panelnumber != 20)

        {
            gameManagement.currentPanel = panelnumber;

            
        }


        panelAnimations = 1;
        //Find the Main Canvas so we can set that as the Parent when introducing new Panels
        maincanvas = GameObject.FindGameObjectWithTag("MainCanvas");
        //Set Open position so it is off Screen
        OpenPosition = new Vector3(-3000, 0, 0);

        //set for the startscreen so it doesnt slide in intially
        if (spawn == true)
        {
            
            LeanTween.moveLocal(this.gameObject, new Vector3(0, 0, 0), speed).setEaseInOutBack();
        }
        // If the panel that this script is attached to has addweek set to true then get the gamemanagment script and add a week to the counter
        if (addweek == true)
        {
            gameManagement.addweek();
            
        }
        
    }

   



    //Moves the current panel out
    public void MovePanelOut()
    {
        
        if (multipleplayerPanel == true && panelAnimations != gameManagement.numberOfPlayers)
        {
            
            this.gameObject.LeanMoveLocal(new Vector3(3000, 0, 0), speed).setEaseInOutBack();
            StartCoroutine(BringBackPanel(PanelInDelay));
            panelAnimations++;
        }
        else {

            

            this.gameObject.LeanMoveLocal(new Vector3 (3000,0,0), speed).setEaseInOutBack();
            LeanTween.delayedCall(this.gameObject, 2f, DestroyPanel);
            panelAnimations = 1;

            if (spawn == false)
            {
               // StartCoroutine(AnimatePanelIn(PanelInDelay));
            }

            

            else
            {
                //Creates and destroys a panel using delays so they happen off screen 
                LeanTween.delayedCall(this.gameObject, 1f, CreatePanel);
                LeanTween.delayedCall(this.gameObject, 2f, DestroyPanel);
            }
            
            
        }

    }




    
    IEnumerator AnimatePanelIn(float Time)

    {
        yield return new WaitForSeconds(0.5f);
        
        this.gameObject.SetActive(false);



    }




    //Brings back the same panel if reused for another player
    IEnumerator BringBackPanel(float Time)
    {
        yield return new WaitForSeconds(.9f);


        this.gameObject.transform.localPosition = new Vector3(-3000, 0, 0);

        this.gameObject.LeanMoveLocal(new Vector3(0,0,0), speed).setEaseInOutBack();
    }




    //Creates a new panel
    public void CreatePanel()

    {

        //Show a particular panel based on what week it is
        if (showCupTransfers == true)

        {
            if (gameManagement.Week == 1 || gameManagement.Week == 6)
            {
                GameObject cupGameObject = (GameObject)Instantiate(cupPanel);
                cupGameObject.transform.localPosition = OpenPosition;
                cupGameObject.transform.SetParent(maincanvas.transform, false);
            }

            else if (gameManagement.Week == 3 || gameManagement.Week == 7)

            {
                GameObject fixGameObject = (GameObject)Instantiate(transfersPanel);
                fixGameObject.transform.localPosition = OpenPosition;
                fixGameObject.transform.SetParent(maincanvas.transform, false);

            }

            else if (gameManagement.Week == 4 || gameManagement.Week == 8)

            {
                GameObject fixGameObject = (GameObject)Instantiate(CcupPanel);
                fixGameObject.transform.localPosition = OpenPosition;
                fixGameObject.transform.SetParent(maincanvas.transform, false);

            }


            else if (gameManagement.Week == 5 || gameManagement.Week == 9)

            {
                GameObject fixGameObject = (GameObject)Instantiate(EcupPanel);
                fixGameObject.transform.localPosition = OpenPosition;
                fixGameObject.transform.SetParent(maincanvas.transform, false);

            }

            else if (gameManagement.Week == 6 || gameManagement.Week == 10)

            {
                GameObject fixGameObject = (GameObject)Instantiate(UcupPanel);
                fixGameObject.transform.localPosition = OpenPosition;
                fixGameObject.transform.SetParent(maincanvas.transform, false);

            }

            else if (gameManagement.Week == 2 || gameManagement.Week == 10)

            {
                GameObject fixGameObject = (GameObject)Instantiate(youWonPanel);
                fixGameObject.transform.localPosition = OpenPosition;
                fixGameObject.transform.SetParent(maincanvas.transform, false);

            }



        }

       


       
        else
        {
            GameObject newgameObject = (GameObject)Instantiate(PanelToOpen);
            newgameObject.transform.localPosition = OpenPosition;
            newgameObject.transform.SetParent(maincanvas.transform, false);

        }


        //save the game
        if (saveGame == true)

        {

            gameManagementObj.GetComponent<SavingLoading>().addSaveData();


        }
        

       


    }
    //destroys the current panel
    private void DestroyPanel()
    {
        Destroy(this.gameObject);
    }

}
