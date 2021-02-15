using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenSalesPage : MonoBehaviour
{
    public string website;
   
    public void OpenWebPage()

    {
        Application.OpenURL(website);

    }
}
