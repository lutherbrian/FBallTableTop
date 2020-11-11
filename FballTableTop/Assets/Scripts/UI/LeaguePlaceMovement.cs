using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeaguePlaceMovement : MonoBehaviour
{

    float speed = .5f;
    AudioSource swoop;
    public float pitch = 1f;
    
    

    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.transform.localPosition = new Vector3(-1500, 0, 0);
        swoop = this.gameObject.GetComponent<AudioSource>();
        Moveposition();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


   public void  Moveposition()
    {
        

        LeanTween.moveLocal(this.gameObject, new Vector3(0, 0, 0), speed).setEaseOutExpo();
        StartCoroutine(playsound());
    }


    IEnumerator playsound()
    {


        yield return new WaitForSeconds (.5f);
        //swoop.pitch += pitch;
        //swoop.Play();


    }
}
