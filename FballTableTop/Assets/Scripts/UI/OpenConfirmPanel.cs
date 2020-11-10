using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenConfirmPanel : MonoBehaviour
{

    private float speed = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void openPanel()
    {
        LeanTween.scale(this.gameObject, new Vector3(1, 1, 1), speed).setEaseOutBack();
    }

    public void closePanel()
    {
        LeanTween.scale(this.gameObject, new Vector3(0, 0, 0), speed).setEaseInBack();
    }
}
