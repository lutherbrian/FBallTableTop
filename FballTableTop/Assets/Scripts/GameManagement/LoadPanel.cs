
using UnityEngine;

public class LoadPanel : MonoBehaviour
{
    public int panelNumber;
    public GameObject StartPanel;
    public GameObject formation;
    public GameObject results;
    public GameObject dice;
    public GameObject league;
    public GameObject fixtures;
    public GameObject cupFixtures;
    public GameObject Transfer;
    
    private GameObject mainCanvas;

    // Start is called before the first frame update
    void Start()
    {
        mainCanvas = GameObject.FindGameObjectWithTag("MainCanvas");
    }

   
    


    public void MoveStartScreen()

    {

        StartPanel.LeanMoveLocal(new Vector3(3000, 0, 0), .8f).setEaseInOutBack();
        LeanTween.delayedCall(this.gameObject, 2f, MoveLoadedPanelIn);


    }


    public GameObject selectLoadedPanel()

    {

        switch (panelNumber)
        {
            case 8:
                return cupFixtures;
            case 7:
                return formation;
            case 6:
                return Transfer;
            case 5:
                return dice;
            case 4:
                return league;
            case 3:
                return results;
            case 2:
                return fixtures;
            case 1:
                return formation;
            case 20:
                return formation;





        }
        return null;
    }




    void MoveLoadedPanelIn()

    {
        GameObject newgameObject = (GameObject)Instantiate(selectLoadedPanel());
        newgameObject.transform.localPosition = new Vector3(-3000, 0, 0);
        newgameObject.transform.SetParent(mainCanvas.transform, false);

    }




}
