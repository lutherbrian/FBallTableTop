using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomImage : MonoBehaviour
{

    public Texture image1;
    public Texture image2;
    public Texture image3;
    public Texture image4;
    public Texture image5;
    private float time = 1;


    public RawImage background;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void fadeimage()

    {
        background.CrossFadeColor(new Color(1, 1, 1, 0), time, false, true);
        LeanTween.delayedCall(gameObject, 1.0f, updateimage);

    }

    public void updateimage()

    {
        int random = Random.Range(0, 4);
        switch (random)
        {

            case 0:
                background.CrossFadeColor(new Color(1, 1, 1, 1), time, true, true);
                background.texture = image1;
                
                break;

            case 1:
                background.CrossFadeColor(new Color(1, 1, 1, 1), time, true, true);
                background.texture = image2;
                
                break;

            case 2:
                background.CrossFadeColor(new Color(1, 1, 1, 1), time, true, true);
                background.texture = image3;
                
                break;

            case 3:
                background.CrossFadeColor(new Color(1, 1, 1, 1), time, true, true);
                background.texture = image4;
                
                break;

            case 4:
                background.CrossFadeColor(new Color(1, 1, 1, 1), time, true, true);
                background.texture = image5;
                
                break;



        }

    }
}
