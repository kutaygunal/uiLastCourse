using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameState : MonoBehaviour 
{
	private GameObject[] coins;
	public int totalCoins;


	public bool gameRunning = false;

	// Use this for initialization
	void Awake () 
	{

	}
	
	// Update is called once per frame
	void Update () 
	{

	}

	public void StartGame()
	{
		gameRunning = true;
	}

	public void GameOver()
	{
		gameRunning = false;
		print ("Game Over!");
	}
}
