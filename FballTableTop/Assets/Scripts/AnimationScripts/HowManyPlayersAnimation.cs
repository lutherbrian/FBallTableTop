using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HowManyPlayersAnimation : MonoBehaviour
{

    public GameObject First;
    public GameObject Second;
    public GameObject Third;
    public GameObject Fourth;
    public GameObject Fith;
    public float speed = .1f;
    // Start is called before the first frame update
    private void Start()
    {

        this.gameObject.LeanDelayedCall(.7f, ShowCards);

    }

    public void ShowCards()

    {
        this.gameObject.LeanDelayedCall(speed, ShowFirst);
        speed += .1f;
        this.gameObject.LeanDelayedCall(speed, Showsecond);
        speed += .1f;
        this.gameObject.LeanDelayedCall(speed, ShowThird);
        speed += .1f;
        this.gameObject.LeanDelayedCall(speed, ShowFourth);
        speed += .1f;
        this.gameObject.LeanDelayedCall(speed, ShowFith);
        speed += .1f;

    }

   

    public void ShowFirst()

    {

            First.LeanMoveLocal(new Vector3(-353, -160, 0), .5f).setEaseOutBack();

    }

    public void Showsecond()

    {

        Second.LeanMoveLocal(new Vector3(-178, -160, 0), .5f).setEaseOutBack();

    }

    public void ShowThird()

    {

        Third.LeanMoveLocal(new Vector3(-3, -160, 0), .5f).setEaseOutBack();

    }


    public void ShowFourth()

    {

        Fourth.LeanMoveLocal(new Vector3(172, -160, 0), .5f).setEaseOutBack();

    }

    public void ShowFith()

    {

       Fith.LeanMoveLocal(new Vector3(347, -160, 0), .5f).setEaseOutBack();

    }

}
