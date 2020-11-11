using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetNumberOfPlayers : MonoBehaviour
{

    private GameManagment Gamemanager;
    // Start is called before the first frame update
    void Start()
    {
        Gamemanager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManagment>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NumberOfPlayers(int number)

    {
        Gamemanager.numberOfPlayers = number;

    }
}
