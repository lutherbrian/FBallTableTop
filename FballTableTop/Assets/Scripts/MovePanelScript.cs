using System.Collections;
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
    public bool addcupfixtures = false;
    private int panelAnimations;
    public GameObject PanelToOpen;
    public GameObject fCupFixtures;
    private GameObject maincanvas;
    private Vector3 OpenPosition;
    private GameManagment gameManagement;
    private GameObject gameManagementObj;
    

    
    void Start()
    {
        
        
        gameManagementObj = GameObject.FindGameObjectWithTag("GameManager");
        gameManagement = gameManagementObj.GetComponent<GameManagment>();


        //only change the panel number if is not set to 20. Means the game won't load into certain panels. 
        if (panelnumber != 20)

        {
            gameManagement.currentPanel = panelnumber;

            
        }


        panelAnimations = 1;
        maincanvas = GameObject.FindGameObjectWithTag("MainCanvas");
        OpenPosition = new Vector3(-3000, 0, 0);

        //set for the startscreen so it doesnt slide in intially
        if (spawn == true)
        {
            
            LeanTween.moveLocal(this.gameObject, new Vector3(0, 0, 0), speed).setEaseInOutBack();
        }

        if (addweek == true)
        {
            gameManagement.addweek();
            Debug.Log("week added");
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
                
                CreatePanel();
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


        if (addcupfixtures == true)

        {
            if (gameManagement.Week == 2 || gameManagement.Week == 3)
            {
                GameObject newgameObject = (GameObject)Instantiate(fCupFixtures);
                newgameObject.transform.localPosition = OpenPosition;
                newgameObject.transform.SetParent(maincanvas.transform, false);
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
