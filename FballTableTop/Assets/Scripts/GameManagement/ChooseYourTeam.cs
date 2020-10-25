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
    private int PlayerNUM = 0;
    private GameObject Team;
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
        
                Team = GameObject.Find("Team"+PlayerNUM);
                Team.GetComponent<Team>().playerName = inputfield.text;
                Team.GetComponent<Team>().TeamName = dropdown.options[dropdown.value].text;
       // Team.gameObject.name = (inputfield.text + "'s Team");
                inputfield.text = "";

                PlayerNUM++;
             


    }

    
}
