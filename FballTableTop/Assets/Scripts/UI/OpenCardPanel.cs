using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenCardPanel : MonoBehaviour
{

    private GameObject thisgameobject;
    private float speed = 0.5f;
    private Vector3 targetsize;
    private Vector3 backsize;
    // Start is called before the first frame update
    void Start()
    
    {

       targetsize = new Vector3(1, 1, 1);
       backsize = new Vector3(0, 0, 0);

        thisgameobject = this.gameObject;
        thisgameobject.transform.localScale = new Vector3(0, 0, 0);
        LeanTween.scale(thisgameobject, targetsize, speed).setEaseOutBack();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ReturnAndDestroy()

    {

        LeanTween.scale(thisgameobject, backsize, speed).setEaseOutBack();

        Destroy(this.gameObject, 1);

    }

   
}
