
using UnityEngine;

public class OpenCloseSettings : MonoBehaviour
{

    private bool open = false;
   
   

    public void OpenClose()

    {

        if (open == false)
        {

            this.gameObject.LeanMoveLocalY(-45, .75f).setEaseInOutBack();
            open = true;
        }

        else
        {



            this.gameObject.LeanMoveLocalY(45, .75f).setEaseInOutBack();
            open = false;
        }
    }

   
}
