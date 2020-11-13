using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Team : MonoBehaviour
{




    [SerializeField] public string playerName;
    [SerializeField] public string TeamName;
    [SerializeField] public int played = 5;

    [SerializeField] public int playerAtk = 10;
    [SerializeField] public int playerDef = 10;
    [SerializeField] public int Pts = 0;
    [SerializeField] public int Gf = 0;
    [SerializeField] public int Ga = 0;
    [SerializeField] public int GD = 0;
    [SerializeField] public bool FormationChanged = false;
    [SerializeField] public int Formation = 3;



    // Start is called before the first frame update
    void Start()
    {
        Pts = Random.Range(0, 90);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
