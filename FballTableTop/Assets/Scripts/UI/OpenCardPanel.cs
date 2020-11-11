using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using GoogleSheetsToUnity;
using TMPro;

public class OpenCardPanel : MonoBehaviour
{

    private GameObject thisgameobject;
    private float speed = 0.5f;
    private Vector3 targetsize;
    private Vector3 backsize;
    private string GSheet = "1NOw71W83VyCQ0tga9K8zWtMWpQ3ZwFXVrgBCRIA41Yg";
    public TextMeshProUGUI Text;
    public bool Cash;
    public bool Luck;
    public bool Selection;
    // Start is called before the first frame update
    void Start()
    
    {

       targetsize = new Vector3(1, 1, 1);
       backsize = new Vector3(0, 0, 0);

        thisgameobject = this.gameObject;
        thisgameobject.transform.localScale = new Vector3(0, 0, 0);
        LeanTween.scale(thisgameobject, targetsize, speed).setEaseOutBack();

        ChooseMessage();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ReturnAndDestroy()

    {

        LeanTween.scale(thisgameobject, backsize, speed).setEaseInBack();

        Destroy(this.gameObject, 1);

    }

    public void ChooseMessage()

    {


        if (Luck == true)
        {
            SpreadsheetManager.Read(new GSTU_Search(GSheet, "ManagersLuck"), UpdateText);
        }

        if (Cash == true)

        {

            SpreadsheetManager.Read(new GSTU_Search(GSheet, "Cash"), UpdateText);
        }


        if (Selection == true)

        {
            SpreadsheetManager.Read(new GSTU_Search(GSheet, "Selection"), UpdateText);

        }

        





    }

    void UpdateText(GstuSpreadSheet spreadsheetRef)
    {

        
        int random = Random.Range(1,52);
        Text.text = spreadsheetRef["A"+random].value;


     }

}
