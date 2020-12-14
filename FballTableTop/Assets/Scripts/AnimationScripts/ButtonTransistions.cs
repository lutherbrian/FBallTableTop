using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ButtonTransistions : MonoBehaviour
{

  
    private float speed = .2f;
    public Vector3 bigSize;
    public Vector3 smallSize;

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
        this.gameObject.LeanScale(bigSize, speed);

    }

    public void UnHover()
    {
        this.gameObject.LeanScale(smallSize, speed);

    }
}
