using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollDice : MonoBehaviour
{

    public GameObject dice;
    // Start is called before the first frame update
    void Start()
    {
        dice = GameObject.FindGameObjectWithTag("Dice");
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void RollTheDice()

    {

        dice.GetComponent<Dice>().DiceRool();
    }
}
