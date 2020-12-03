using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveButton : MonoBehaviour
{

    public bool saveGame = true;

    

    GameObject gameManagement;
    // Start is called before the first frame update
    void Start()
    {
      gameManagement = GameObject.FindGameObjectWithTag("GameManager");
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void SaveGame()

    {
        if (saveGame == true)

        {
            gameManagement.GetComponent<SavingLoading>().addSaveData();

            Debug.Log("StartSaving");

        }



    }

    public void AddWeek()

    {

        
    }
}
