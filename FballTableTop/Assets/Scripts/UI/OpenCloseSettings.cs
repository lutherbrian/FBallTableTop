
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class OpenCloseSettings : MonoBehaviour
{

    private bool open = false;
    public GameObject First;
    public GameObject Second;
    public GameObject Third;
    public GameObject Fourth;
    public GameObject Line;
    public GameObject Line2;
    public GameObject Fith;

    public TMP_Text SeasonNumber;
    public TMP_Text WeekNumber;
    public GameObject gameManagment;
    private float time = .1f;



    private void Start()
    {
        
        this.gameObject.transform.localScale = new Vector3(0, 0, 0);
        First.transform.localScale = new Vector3(0, 0, 0);
        Second.transform.localScale = new Vector3(0, 0, 0);
        Third.transform.localScale = new Vector3(0, 0, 0);
        Fourth.transform.localScale = new Vector3(0, 0, 0);
    }

    public void OpenClose()

    {

        if (open == false)
        {

            this.gameObject.LeanScale(new Vector3 (2,2,2), .5f).setEaseOutBack();
            this.gameObject.LeanDelayedCall(.3f, ShowFirst);
            SeasonNumber.text = gameManagment.GetComponent<GameManagment>().Season.ToString();
            WeekNumber.text = gameManagment.GetComponent<GameManagment>().Week.ToString();

        }

        else
        {

            ShowFith();
            
        }
    }

    public void ShowFirst()

    {
        if (open == false)
        {
            First.LeanScale(new Vector3(1, 1, 1), .5f).setEaseOutBack();
            this.gameObject.LeanDelayedCall(time, ShowSecond);

        }

        else
        {

            First.LeanScale(new Vector3(0, 0, 0), .5f).setEaseInBack();
            this.gameObject.LeanScale(new Vector3(0, 0, 0), .5f).setEaseInBack();
            open = false;

        }

    }

    public void ShowSecond()

    {
        if (open == false)
        {
            Second.LeanScale(new Vector3(1, 1, 1), .5f).setEaseOutBack();
            this.gameObject.LeanDelayedCall(time, ShowThird);
            this.gameObject.LeanDelayedCall(time, drawLine);

        }

        else
        {

           Second.LeanScale(new Vector3(0, 0, 0), .5f).setEaseInBack();
            this.gameObject.LeanDelayedCall(time, ShowFirst);
            


        }

    }

    public void ShowThird()

    {
        if (open == false)
        {
            Third.LeanScale(new Vector3(1, 1, 1), .5f).setEaseOutBack();
            Line2.transform.LeanScale(new Vector3(1, 1, 1), .3f);
            Fith.LeanMoveLocal(new Vector3(150, 0, 0), .3f);
            this.gameObject.LeanDelayedCall(time, ShowFourth);

        }

        else
        {

            Third.LeanScale(new Vector3(0, 0, 0), .5f).setEaseInBack();
            this.gameObject.LeanDelayedCall(time, ShowSecond);

        }

    }

    public void ShowFourth()

    {
        if (open == false)
        {
           Fourth.LeanScale(new Vector3(1, 1, 1), .5f).setEaseOutBack();
            this.gameObject.LeanDelayedCall(time, ShowFith);


        }

        else
        {

            Fourth.LeanScale(new Vector3(0, 0, 0), .5f).setEaseInBack();
            this.gameObject.LeanDelayedCall(time, ShowThird);
            this.gameObject.LeanDelayedCall(time, drawLine);


        }

    }


    public void ShowFith()

    {
        if (open == false)
        {
            


            open = true;

        }

        else
        {
            Line2.transform.LeanScale(new Vector3(0, 0, 0), .5f);
            Fith.LeanMoveLocal(new Vector3(-134, 0, 0), .5f).setEaseOutQuart();
            this.gameObject.LeanDelayedCall(time, ShowFourth);
            


        }

    }

    public void drawLine()
    {


        if (open == false)

        {
            Line.transform.LeanScale(new Vector3(1, 1, 1), .3f);
            
            

        }

        else
        {

            Line.transform.LeanScale(new Vector3(0, 0, 0), .3f);
            

        }

    }


}
