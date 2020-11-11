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
        this.gameObject.transform.SetAsLastSibling();
    }


    public void OpenClose()

    {

        if (open == false)
        {
            LeanTween.rotate(this.gameObject, new Vector3(0, 0, -90), .75f).setEaseOutBack();
            open = true;
        }

        else if(WindowOpen == false)
        {

            LeanTween.rotate(this.gameObject, new Vector3(0, 0, 90), .75f).setEaseInBack();
            open = false;
        }
    }

   
}
