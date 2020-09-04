using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ChooseYourTeam : MonoBehaviour
{

    public GameObject gameManagment;
    public TMP_Dropdown dropdown;
    public TMP_InputField inputfield;
    
    private GameManagment gamemanagementScript;
    private int PlayerNUM = 1;
    // Start is called before the first frame update
    void Start()
    {
        
        gamemanagementScript = gameManagment.GetComponent<GameManagment>();
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    public void AddPlayer()
    {
        switch (PlayerNUM)

        {
         
        case 5:
                gamemanagementScript.player5Name = inputfield.text;
                gamemanagementScript.player5Team = dropdown.options[dropdown.value].text;
                inputfield.text= "";
                dropdown.options.RemoveAt(0);
                dropdown.options.RemoveAll(c => c.text.Contains(gamemanagementScript.player5Team.ToString()));
                PlayerNUM++;
            break;
        case 4:
                gamemanagementScript.player4Name = inputfield.text;
                gamemanagementScript.player4Team = dropdown.options[dropdown.value].text;
                inputfield.text = "";
                dropdown.options.RemoveAll(c => c.text.Contains(gamemanagementScript.player4Team.ToString()));
                PlayerNUM++;
                break;
        case 3:
                gamemanagementScript.player3Name = inputfield.text;
                gamemanagementScript.player3Team = dropdown.options[dropdown.value].text;
                inputfield.text= "";
                dropdown.options.RemoveAll(c => c.text.Contains(gamemanagementScript.player3Team.ToString()));
                PlayerNUM++;
                break;
        case 2:
                gamemanagementScript.player2Name = inputfield.text;
                gamemanagementScript.player2Team = dropdown.options[dropdown.value].text;
                inputfield.text = "";
                dropdown.options.RemoveAll(c => c.text.Contains(gamemanagementScript.player2Team.ToString()));
                PlayerNUM++;
                break;
        case 1:
                gamemanagementScript.player1Name = inputfield.text;
                gamemanagementScript.player1Team = dropdown.options[dropdown.value].text;
                inputfield.text = "";
                dropdown.options.RemoveAt(dropdown.value);
                
                PlayerNUM++;
                break;
            default:
            print("Incorrect intelligence level.");
            break;
        }


    }

    
}
