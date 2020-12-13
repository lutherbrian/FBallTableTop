using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenSalesPage : MonoBehaviour
{
    public string website;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OpenWebPage()

    {
        Application.OpenURL(website);

    }
}
