using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ChangetitleNames : MonoBehaviour
{
    private int PlayerNum;

    public TextMeshProUGUI playerinfo;
   
    private GameManagment Gamemanager;
    // Start is called before the first frame update
    void Start()
    {

        Gamemanager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManagment>();


        PlayerNum = 2;
    }

    // Update is called once per frame
    void Update()
    {

    }


    public void ChangeTitle()
    {
        switch (PlayerNum)

        {

            case 5:
                playerinfo.text = Gamemanager.player5Team + " - " + Gamemanager.player5Name;
                PlayerNum++;
                break;
            case 4:
                playerinfo.text = Gamemanager.player4Team + " - " + Gamemanager.player4Name;
                PlayerNum++;
                break;
            case 3:
                playerinfo.text = Gamemanager.player3Team + " - " + Gamemanager.player3Name;
                PlayerNum++;
                break;
            case 2:
                playerinfo.text = Gamemanager.player2Team + " - " + Gamemanager.player2Name;
                PlayerNum++;
                break;
            case 1:
                playerinfo.text = Gamemanager.player1Team + " - " + Gamemanager.player1Name;
                PlayerNum++;
                break;
            default:
                print("Incorrect intelligence level.");
                break;
        }


    }

    public void Setonce()
    {

        playerinfo.text = Gamemanager.player1Team + " - " + Gamemanager.player1Name;
        
    }
}
