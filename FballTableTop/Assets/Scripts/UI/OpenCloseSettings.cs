
using UnityEngine;

public class OpenCloseSettings : MonoBehaviour
{

    private bool open = false;


    private void Start()
    {
        this.gameObject.transform.localScale = new Vector3(0, 0, 0);
    }

    public void OpenClose()

    {

        if (open == false)
        {

            this.gameObject.LeanScale(new Vector3 (2,2,2), .5f).setEaseOutBack();
            open = true;
        }

        else
        {



            this.gameObject.LeanScale(new Vector3(0, 0, 0), .5f).setEaseInBack();
            open = false;
        }
    }

   
}
