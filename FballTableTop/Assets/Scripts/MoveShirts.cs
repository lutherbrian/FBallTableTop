using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveShirts : MonoBehaviour
{
    [Header("Shirts")]

    public GameObject SGK442;
    public GameObject SP1442;
    public GameObject SP2442;
    public GameObject SP3442;
    public GameObject SP4442;
    public GameObject SP5442;
    public GameObject SP6442;
    public GameObject SP7442;
    public GameObject SP8442;
    public GameObject SP9442;
    public GameObject SP10442;

    [Header("4-4-2")]
    public GameObject SGK;
    public GameObject SP1;
    public GameObject SP2;
    public GameObject SP3;
    public GameObject SP4;
    public GameObject SP5;
    public GameObject SP6;
    public GameObject SP7;
    public GameObject SP8;
    public GameObject SP9;
    public GameObject SP10;

    [Header("4-3-3")]
    public GameObject SGK433;
    public GameObject SP1433;
    public GameObject SP2433;
    public GameObject SP3433;
    public GameObject SP4433;
    public GameObject SP5433;
    public GameObject SP6433;
    public GameObject SP7433;
    public GameObject SP8433;
    public GameObject SP9433;
    public GameObject SP10433;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   public void Move442()
    {
        LeanTween.move(SP10442, SP10.transform.position, .1f);
    }

    public void Move433()
    {
        LeanTween.move(SP10442, SP10433.transform.position, .1f);
    }
}
