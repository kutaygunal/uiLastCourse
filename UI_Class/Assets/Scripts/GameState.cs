using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameState : MonoBehaviour 
{
	private GameObject[] coins;
	public int totalCoins;

	private CoinCounter coinCounter;
	public bool gameRunning = false;

	// Use this for initialization
	void Awake () 
	{
		coinCounter = GameObject.Find("CoinCount").GetComponent<CoinCounter>();
		coins = GameObject.FindGameObjectsWithTag("Coin");
		totalCoins = coins.Length;
	}
	
	// Update is called once per frame
	void Update () 
	{
		int collectedCoins = coinCounter.coinCount;
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
