using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class LeagueData : MonoBehaviour
{ 

Dictionary<string, Dictionary<string, int>> playerScores;
  



	int changeCounter = 0;

	void Start()

    {
    }



void Init()

    {
	if (playerScores != null)
		return;

	playerScores = new Dictionary<string, Dictionary<string, int>>();
    }



public void Reset()
    {
	changeCounter++;
	playerScores = null;
    }



public int GetScore(string username, string scoreType)
    {
   	Init();

	if (playerScores.ContainsKey(username) == false)
	{
		// We have no score record at all for this username
		return 0;
	}

	if (playerScores[username].ContainsKey(scoreType) == false)
	{
		return 0;
	}

	return playerScores[username][scoreType];
    }



public void SetPoints(string username, string scoreType, int value)
    {
	Init();

	changeCounter++;

	if (playerScores.ContainsKey(username) == false)
	{
		playerScores[username] = new Dictionary<string, int>();
	}

	playerScores[username][scoreType] = value;
    }



public void ChangeScore(string username, string scoreType, int amount)
    {
	Init();
	int currScore = GetScore(username, scoreType);
	SetPoints(username, scoreType, currScore + amount);
    }



public string[] GetPlayerNames()
    {
	Init();
	return playerScores.Keys.ToArray();
    }



public string[] GetPlayerNames(string sortingScoreType)
    {
	Init();

	return playerScores.Keys.OrderByDescending(n => GetScore(n, sortingScoreType)).ToArray();

       
    }



public int GetChangeCounter()
    {
	return changeCounter;
    }
	

	public void AddNames(string pName)
    {
	SetPoints(pName, "Points", 20);

		//SetScore("quill18", "assists", 345);

		//SetScore("bob", "kills", 1000);
		//SetScore("bob", "deaths", 14345);

		//SetScore("AAAAAA", "kills", 3);
		//SetScore("BBBBBB", "kills", 2);
		//SetScore("CCCCCC", "kills", 1);


		Debug.Log(GetScore(pName, "Points"));
		
    }

}

