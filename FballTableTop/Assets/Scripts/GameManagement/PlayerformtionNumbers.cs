using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerformtionNumbers : MonoBehaviour
{
    public TMP_InputField Attackinput;

    public TMP_InputField Defenseinput;

    private int AttackNumber;
    private int DefenseNumber;

    public 
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Incrementattack ()

        {

       AttackNumber = int.Parse(Attackinput.text);
       AttackNumber++;
       Attackinput.text = AttackNumber.ToString();

}


    public void Decrementattack()

    {

        AttackNumber = int.Parse(Attackinput.text);
        AttackNumber--;
        Attackinput.text = AttackNumber.ToString();

    }


    public void IncrementDefense()

    {

        DefenseNumber = int.Parse(Defenseinput.text);
        DefenseNumber++;
        Defenseinput.text = DefenseNumber.ToString();

    }


    public void DecrementDefense()

    {

        DefenseNumber = int.Parse(Defenseinput.text);
        DefenseNumber--;
        Defenseinput.text = DefenseNumber.ToString();

    }



}
