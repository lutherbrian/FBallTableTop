using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MovePanelIn : MonoBehaviour
{

    public GameObject panel;

    public GameObject StartPosition;
    private float speed = 0.8f;
    private Vector3 EndPosition;

    // Start is called before the first frame update
    void Start()
    {
        
        EndPosition = new Vector3(0.0f, 0.0f, 0.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AnimatePanelIn()
    {
       panel.transform.localPosition = StartPosition.transform.position;

  

        panel.LeanMoveLocal(EndPosition, speed).setEaseInOutBack();

        
    }

}
