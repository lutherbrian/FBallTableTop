using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MovePanelScript : MonoBehaviour
{

    
    
    private float speed = 0.8f;
    public float PanelInDelay = 2.5f;
    
    public GameObject StartPosition;
    

    public bool multipleplayerPanel = false;
    public bool spawn = true;
    public GameObject gameManagement;
    
    private int panelAnimations;

    public GameObject PanelToOpen;
    public GameObject maincanvas;
    private Vector3 OpenPosition;




    // Start is called before the first frame update
    void Start()
    {
        
        
        gameManagement = GameObject.FindGameObjectWithTag("GameManager");
        panelAnimations = 1;



       maincanvas = GameObject.FindGameObjectWithTag("MainCanvas");
       OpenPosition = new Vector3(-3000, 0, 0);

        if (spawn == true)
        {
            
            LeanTween.moveLocal(this.gameObject, new Vector3(0, 0, 0), speed).setEaseInOutBack();
        }
    }

   




    public void MovePanelOut()
    {

        if (multipleplayerPanel == true && panelAnimations != gameManagement.GetComponent<GameManagment>().numberOfPlayers)
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
                StartCoroutine(AnimatePanelIn(PanelInDelay));
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

    IEnumerator BringBackPanel(float Time)
    {
        yield return new WaitForSeconds(.9f);


        this.gameObject.transform.localPosition = new Vector3(-3000, 0, 0);

        this.gameObject.LeanMoveLocal(new Vector3(0,0,0), speed).setEaseInOutBack();
    }


    public void CreatePanel()

    {
        
        GameObject newgameObject = (GameObject)Instantiate(PanelToOpen);
       newgameObject.transform.localPosition = OpenPosition;

       newgameObject.transform.SetParent(maincanvas.transform, false);
        



    }

    private void DestroyPanel()
    {
        Destroy(this.gameObject);
    }

}
