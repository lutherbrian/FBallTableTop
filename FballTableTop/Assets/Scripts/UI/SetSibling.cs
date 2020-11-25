using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetSibling : MonoBehaviour
{
    public int BackImageNum = 2;
    GameObject Canvas;
    public int index = 2;
    public bool changeBackground = true;
    // Start is called before the first frame update
    void Start()
    {
        if(changeBackground == true)
        {

            SetBackground();
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        this.gameObject.transform.SetSiblingIndex(index);
        
       
    }

    public void SetBackground()

    {
      Canvas = GameObject.FindGameObjectWithTag("MainCanvas");
       Canvas.GetComponent<RandomImage>().fadeimage(BackImageNum);

    }
}
