using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ButtonTransistions : MonoBehaviour
{

  
    private float speed = .5f;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Hover()
    {
        LeanTween.scaleX(this.gameObject, 1.2f, speed);

    }
}
