using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetSibling : MonoBehaviour
{

    public int index = 2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.gameObject.transform.SetSiblingIndex(index);
    }
}
