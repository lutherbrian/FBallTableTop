using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using KoganeUnityLib;

public class ResultsPrinter : MonoBehaviour
{

    private TMP_Typewriter type;

    public float speed = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
 type.Play(
    text: "ABCDEFG HIJKLMN OPQRSTU",
    speed: speed,
    onComplete: () => Debug.Log("Complete !")
);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
