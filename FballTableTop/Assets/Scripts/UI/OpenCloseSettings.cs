using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenCloseSettings : MonoBehaviour
{

    private bool open = false;
    private bool WindowOpen = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void OpenClose()

    {

        if (open == false)
        {
            //LeanTween.rotate(this.gameObject, new Vector3(0, 0, -90), .75f).setEaseOutBack();
            //LeanTween.moveLocal(this.gameObject, new Vector3(0, 0, 0), .75f).setEaseOutBack();
            LeanTween.moveLocal(this.gameObject, new Vector3(-500, -500, 0), .75f).setEaseOutBack();
            open = true;
        }

        else if(WindowOpen == false)
        {

            // LeanTween.rotate(this.gameObject, new Vector3(0, 0, 90), .75f).setEaseInBack();
            //LeanTween.moveLocal(this.gameObject, new Vector3(0, -125, 0), .75f).setEaseInBack();
            LeanTween.moveLocal(this.gameObject, new Vector3(-500, -600, 0), .75f).setEaseOutBack();
            open = false;
        }
    }

   
}
