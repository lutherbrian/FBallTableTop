using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NumberofPlayersSelect : MonoBehaviour
{
    public Button player1;
    public Button player2;
    public Button player3;
    public Button player4;
    public Button player5;
   

    public int numberOfPlayersSelected;

    public GameManagment gameManagment;
    // Start is called before the first frame update
    void Start()
    {

        gameManagment = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManagment>();
        player1.onClick.AddListener(() => playerselected(1));
        player2.onClick.AddListener(() => playerselected(2));
        player3.onClick.AddListener(() => playerselected(3));
        player4.onClick.AddListener(() => playerselected(4));
        player5.onClick.AddListener(() => playerselected(5));
    }

  


    public void SetGameManagmentPlayerNumbers()
        {

        gameManagment.GetComponent<GameManagment>().numberOfPlayers = numberOfPlayersSelected;


        }



    public void playerselected(int numberPl)

    {
        numberOfPlayersSelected = numberPl;

    }

}
