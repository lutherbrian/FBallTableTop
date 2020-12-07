using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnLeagueSettings : MonoBehaviour
{



    private float speed = 0.8f;
  

    


  

    private GameObject gameManagement;

    private int panelAnimations;

    public GameObject PanelToOpen;
    private GameObject maincanvas;
    private Vector3 OpenPosition;




    // Start is called before the first frame update
    void Start()
    {


        gameManagement = GameObject.FindGameObjectWithTag("GameManager");
        panelAnimations = 1;



        maincanvas = GameObject.FindGameObjectWithTag("MainCanvas");
        OpenPosition = new Vector3(-3000, 0, 0);

      
    }






    public void MovePanelOut()
    {
        



            PanelToOpen.LeanMoveLocal(new Vector3(3000, 0, 0), speed).setEaseInOutBack();
            LeanTween.delayedCall(this.gameObject, 2f, DestroyPanel);
            
      

    }





    



    public void CreatePanel()

    {


        this.gameObject.LeanDelayedCall(.75f, openpanel);


    }

    void openpanel()
    {

        GameObject newgameObject = (GameObject)Instantiate(PanelToOpen);
        newgameObject.transform.localPosition = OpenPosition;

        newgameObject.transform.SetParent(maincanvas.transform, false);

    }




    private void DestroyPanel()
    {
        Destroy(PanelToOpen.gameObject);
    }

}
