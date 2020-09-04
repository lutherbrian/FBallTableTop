using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MovePanelScript : MonoBehaviour
{

    private GameObject PanelOut;
    public GameObject EndPositionPOUT;
    private float speed = 0.8f;

    public float PanelInDelay = 0.0f;

    public GameObject panelIn;

    public GameObject StartPosition;
    private Vector3 EndPositionPIN;
    // Start is called before the first frame update
    void Start()
    {
        PanelOut = this.gameObject;
        EndPositionPIN = new Vector3(0.0f, 0.0f, 0.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MovePanelOut()
    {
        PanelOut.LeanMoveLocal (EndPositionPOUT.transform.position, speed).setEaseInOutBack();

        StartCoroutine(AnimatePanelIn(PanelInDelay));
    }





    IEnumerator AnimatePanelIn(float Time)
    
    {
        yield return new WaitForSeconds(Time);

        panelIn.transform.localPosition = StartPosition.transform.position;



        panelIn.LeanMoveLocal(EndPositionPIN, speed).setEaseInOutBack();


    }
}
