using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeetingAnimation : MonoBehaviour
{

    private bool isActive = false;
    private Vector3 OnScreenPos;
    private Vector3 offScreenPos;
    public GameObject SettingsPanel;



   
    // Start is called before the first frame update
    void Start()
    {
        OnScreenPos = new Vector3(0, 0, 0);
        offScreenPos = new Vector3(0, -800, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MoveSettingsPanel()
        {

        if (isActive == false)

        {
            LeanTween.moveLocal(SettingsPanel, OnScreenPos, .5f).setEaseInOutQuart();
            this.gameObject.transform.SetAsLastSibling();
            isActive = true;


        }

        else
        {

            LeanTween.moveLocal(SettingsPanel, offScreenPos, .5f).setEaseInOutQuart();
            isActive = false;
        }



        }

}
