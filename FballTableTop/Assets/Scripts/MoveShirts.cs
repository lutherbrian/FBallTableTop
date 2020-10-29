using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MoveShirts : MonoBehaviour
{


    public GameObject Team;
    private GameObject gamemanager;
    public int PlayerNum = 0;
    public int FormationNumber;
    public GameObject AttackPanel;
    public GameObject DefensePanel;
    public int TeamAttack;
    public int TeamDefense;

    public GameObject button1;
    public GameObject button2;
    public GameObject button3;
    public GameObject button4;
    public GameObject button5;
    public GameObject button6;
    public GameObject button7;


    [Header("Shirts")]

    public GameObject GKShirt;
    public GameObject P1Shirt;
    public GameObject P2Shirt;
    public GameObject P3Shirt;
    public GameObject P4Shirt;
    public GameObject P5Shirt;
    public GameObject P6Shirt;
    public GameObject P7Shirt;
    public GameObject P8Shirt;
    public GameObject P9Shirt;
    public GameObject P10Shirt;

    [Header("4-4-2")]
    public GameObject SGK;
    public GameObject SP1;
    public GameObject SP2;
    public GameObject SP3;
    public GameObject SP4;
    public GameObject SP5;
    public GameObject SP6;
    public GameObject SP7;
    public GameObject SP8;
    public GameObject SP9;
    public GameObject SP10;

    [Header("4-3-3")]
    public GameObject SGK433;
    public GameObject SP1433;
    public GameObject SP2433;
    public GameObject SP3433;
    public GameObject SP4433;
    public GameObject SP5433;
    public GameObject SP6433;
    public GameObject SP7433;
    public GameObject SP8433;
    public GameObject SP9433;
    public GameObject SP10433;

    [Header("4-5-1")]
    public GameObject SGK451;
    public GameObject SP1451;
    public GameObject SP2451;
    public GameObject SP3451;
    public GameObject SP4451;
    public GameObject SP5451;
    public GameObject SP6451;
    public GameObject SP7451;
    public GameObject SP8451;
    public GameObject SP9451;
    public GameObject SP10451;

    [Header("4-2-4")]
    public GameObject SGK424;
    public GameObject SP1424;
    public GameObject SP2424;
    public GameObject SP3424;
    public GameObject SP4424;
    public GameObject SP5424;
    public GameObject SP6424;
    public GameObject SP7424;
    public GameObject SP8424;
    public GameObject SP9424;
    public GameObject SP10424;

    [Header("3-5-2")]
    public GameObject SGK352;
    public GameObject SP1352;
    public GameObject SP2352;
    public GameObject SP3352;
    public GameObject SP4352;
    public GameObject SP5352;
    public GameObject SP6352;
    public GameObject SP7352;
    public GameObject SP8352;
    public GameObject SP9352;
    public GameObject SP10352;

    [Header("4-3-4")]
    public GameObject SGK434;
    public GameObject SP1434;
    public GameObject SP2434;
    public GameObject SP3434;
    public GameObject SP4434;
    public GameObject SP5434;
    public GameObject SP6434;
    public GameObject SP7434;
    public GameObject SP8434;
    public GameObject SP9434;
    public GameObject SP10434;

    [Header("5-3-2")]
    public GameObject SGK532;
    public GameObject SP1532;
    public GameObject SP2532;
    public GameObject SP3532;
    public GameObject SP4532;
    public GameObject SP5532;
    public GameObject SP6532;
    public GameObject SP7532;
    public GameObject SP8532;
    public GameObject SP9532;
    public GameObject SP10532;

    [Header("Tweaks")]

    public float speed = .1f;

    private void Start()
    {
        GetTeamData();
    }

    public void ChangeFormationfromTeams(int formation)

    {
        switch (formation)
        {
            case 7:
                Move532();
                button7.GetComponent<Button>().Select();
                break;
            case 6:
                Move434();
                button6.GetComponent<Button>().Select();
                break;
            case 5:
                Move352();
                button5.GetComponent<Button>().Select();
                break;
            case 4:
                Move424();
                button4.GetComponent<Button>().Select();
                break;
            case 3:
                Move451();
                button3.GetComponent<Button>().Select();
                break;
            case 2:
                Move433();
                button2.GetComponent<Button>().Select();
                break;
            case 1:
                Move442();
                button1.GetComponent<Button>().Select();
                break;
            default:
                print("Incorrect intelligence level.");
                break;
        }

    }

    public void AddAtkDef()

    {

        TeamAttack = int.Parse(AttackPanel.GetComponent<TMP_InputField>().text);
        TeamDefense = int.Parse(DefensePanel.GetComponent<TMP_InputField>().text);

    }

    public void UpdateTeam()

    {

        gamemanager = GameObject.FindGameObjectWithTag("GameManager");
        Team = GameObject.Find("Team" + PlayerNum);
       
        if (Team.GetComponent<Team>().playerAtk != TeamAttack || Team.GetComponent<Team>().playerDef!= TeamAttack || Team.GetComponent<Team>().Formation != FormationNumber)
        {
            Team.GetComponent<Team>().FormationChanged = true;

        }


        Team.GetComponent<Team>().Formation = FormationNumber;
        Team.GetComponent<Team>().playerAtk = TeamAttack;
        Team.GetComponent<Team>().playerDef = TeamDefense;
        PlayerNum++;
        StartCoroutine(DelayedMove(2f));

        if (PlayerNum == gamemanager.GetComponent<GameManagment>().numberOfPlayers)
        {

            PlayerNum = 0;
        }


    }

    public void GetTeamData()

    {
        Team = GameObject.Find("Team" + PlayerNum);

        TeamDefense = Team.GetComponent<Team>().playerDef;
        TeamAttack = Team.GetComponent<Team>().playerAtk;
        FormationNumber = Team.GetComponent<Team>().Formation;
        AttackPanel.GetComponent<TMP_InputField>().text = TeamAttack.ToString();
        DefensePanel.GetComponent<TMP_InputField>().text = TeamDefense.ToString();
        

        



    }

    IEnumerator DelayedMove(float time)
    {
        yield return new WaitForSeconds(time);
        
        ChangeFormationfromTeams(FormationNumber);
        GetTeamData();
        Debug.Log("Working");
        yield return null;
        
    }


// Start is called before the first frame update


    public void Move442()
{
    LeanTween.move(P10Shirt, SP10.transform.position, speed).setEaseInOutQuart();
    LeanTween.move(P9Shirt, SP9.transform.position, speed).setEaseInOutQuart();
    LeanTween.move(P8Shirt, SP8.transform.position, speed).setEaseInOutQuart();
    LeanTween.move(P7Shirt, SP7.transform.position, speed).setEaseInOutQuart();
    LeanTween.move(P6Shirt, SP6.transform.position, speed).setEaseInOutQuart();
    LeanTween.move(P5Shirt, SP5.transform.position, speed).setEaseInOutQuart();
    LeanTween.move(P4Shirt, SP4.transform.position, speed).setEaseInOutQuart();
    LeanTween.move(P3Shirt, SP3.transform.position, speed).setEaseInOutQuart();
    LeanTween.move(P2Shirt, SP2.transform.position, speed).setEaseInOutQuart();
    LeanTween.move(P1Shirt, SP1.transform.position, speed).setEaseInOutQuart();
   
    FormationNumber = 1;
}

    public void Move433()
    {
        LeanTween.move(P10Shirt, SP10433.transform.position, speed).setEaseInOutQuart();
        LeanTween.move(P9Shirt, SP9433.transform.position, speed).setEaseInOutQuart();
        LeanTween.move(P8Shirt, SP8433.transform.position, speed).setEaseInOutQuart();
        LeanTween.move(P7Shirt, SP7433.transform.position, speed).setEaseInOutQuart();
        LeanTween.move(P6Shirt, SP6433.transform.position, speed).setEaseInOutQuart();
        LeanTween.move(P5Shirt, SP5433.transform.position, speed).setEaseInOutQuart();
        LeanTween.move(P4Shirt, SP4433.transform.position, speed).setEaseInOutQuart();
        LeanTween.move(P3Shirt, SP3433.transform.position, speed).setEaseInOutQuart();
        LeanTween.move(P2Shirt, SP2433.transform.position, speed).setEaseInOutQuart();
        LeanTween.move(P1Shirt, SP1433.transform.position, speed).setEaseInOutQuart();
        FormationNumber = 2;
    }

    public void Move451()
    {
        LeanTween.move(P10Shirt, SP10451.transform.position, speed).setEaseInOutQuart();
        LeanTween.move(P9Shirt, SP9451.transform.position, speed).setEaseInOutQuart();
        LeanTween.move(P8Shirt, SP8451.transform.position, speed).setEaseInOutQuart();
        LeanTween.move(P7Shirt, SP7451.transform.position, speed).setEaseInOutQuart();
        LeanTween.move(P6Shirt, SP6451.transform.position, speed).setEaseInOutQuart();
        LeanTween.move(P5Shirt, SP5451.transform.position, speed).setEaseInOutQuart();
        LeanTween.move(P4Shirt, SP4451.transform.position, speed).setEaseInOutQuart();
        LeanTween.move(P3Shirt, SP3451.transform.position, speed).setEaseInOutQuart();
        LeanTween.move(P2Shirt, SP2451.transform.position, speed).setEaseInOutQuart();
        LeanTween.move(P1Shirt, SP1451.transform.position, speed).setEaseInOutQuart();
        FormationNumber = 3;
    }

    public void Move424()
    {
        LeanTween.move(P10Shirt, SP10424.transform.position, speed).setEaseInOutQuart();
        LeanTween.move(P9Shirt, SP9424.transform.position, speed).setEaseInOutQuart();
        LeanTween.move(P8Shirt, SP8424.transform.position, speed).setEaseInOutQuart();
        LeanTween.move(P7Shirt, SP7424.transform.position, speed).setEaseInOutQuart();
        LeanTween.move(P6Shirt, SP6424.transform.position, speed).setEaseInOutQuart();
        LeanTween.move(P5Shirt, SP5424.transform.position, speed).setEaseInOutQuart();
        LeanTween.move(P4Shirt, SP4424.transform.position, speed).setEaseInOutQuart();
        LeanTween.move(P3Shirt, SP3424.transform.position, speed).setEaseInOutQuart();
        LeanTween.move(P2Shirt, SP2424.transform.position, speed).setEaseInOutQuart();
        LeanTween.move(P1Shirt, SP1424.transform.position, speed).setEaseInOutQuart();
        FormationNumber = 4;
    }

    public void Move352()
    {
        LeanTween.move(P10Shirt, SP10352.transform.position, speed).setEaseInOutQuart();
        LeanTween.move(P9Shirt, SP9352.transform.position, speed).setEaseInOutQuart();
        LeanTween.move(P8Shirt, SP8352.transform.position, speed).setEaseInOutQuart();
        LeanTween.move(P7Shirt, SP7352.transform.position, speed).setEaseInOutQuart();
        LeanTween.move(P6Shirt, SP6352.transform.position, speed).setEaseInOutQuart();
        LeanTween.move(P5Shirt, SP5352.transform.position, speed).setEaseInOutQuart();
        LeanTween.move(P4Shirt, SP4352.transform.position, speed).setEaseInOutQuart();
        LeanTween.move(P3Shirt, SP3352.transform.position, speed).setEaseInOutQuart();
        LeanTween.move(P2Shirt, SP2352.transform.position, speed).setEaseInOutQuart();
        LeanTween.move(P1Shirt, SP1352.transform.position, speed).setEaseInOutQuart();
        FormationNumber = 5;
    }

    public void Move434()
    {
        LeanTween.move(P10Shirt, SP10434.transform.position, speed).setEaseInOutQuart();
        LeanTween.move(P9Shirt, SP9434.transform.position, speed).setEaseInOutQuart();
        LeanTween.move(P8Shirt, SP8434.transform.position, speed).setEaseInOutQuart();
        LeanTween.move(P7Shirt, SP7434.transform.position, speed).setEaseInOutQuart();
        LeanTween.move(P6Shirt, SP6434.transform.position, speed).setEaseInOutQuart();
        LeanTween.move(P5Shirt, SP5434.transform.position, speed).setEaseInOutQuart();
        LeanTween.move(P4Shirt, SP4434.transform.position, speed).setEaseInOutQuart();
        LeanTween.move(P3Shirt, SP3434.transform.position, speed).setEaseInOutQuart();
        LeanTween.move(P2Shirt, SP2434.transform.position, speed).setEaseInOutQuart();
        LeanTween.move(P1Shirt, SP1434.transform.position, speed).setEaseInOutQuart();
        FormationNumber = 6;
    }


    public void Move532()
    {
        LeanTween.move(P10Shirt, SP10532.transform.position, speed).setEaseInOutQuart();
        LeanTween.move(P9Shirt, SP9532.transform.position, speed).setEaseInOutQuart();
        LeanTween.move(P8Shirt, SP8532.transform.position, speed).setEaseInOutQuart();
        LeanTween.move(P7Shirt, SP7532.transform.position, speed).setEaseInOutQuart();
        LeanTween.move(P6Shirt, SP6532.transform.position, speed).setEaseInOutQuart();
        LeanTween.move(P5Shirt, SP5532.transform.position, speed).setEaseInOutQuart();
        LeanTween.move(P4Shirt, SP4532.transform.position, speed).setEaseInOutQuart();
        LeanTween.move(P3Shirt, SP3532.transform.position, speed).setEaseInOutQuart();
        LeanTween.move(P2Shirt, SP2532.transform.position, speed).setEaseInOutQuart();
        LeanTween.move(P1Shirt, SP1532.transform.position, speed).setEaseInOutQuart();
        FormationNumber = 7;
    }
}
