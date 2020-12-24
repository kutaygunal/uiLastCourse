using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameState : MonoBehaviour 
{
	private GameObject[] coins;
	public int totalCoins;
	private LivesCounter livesCounter;
	private CoinCounter coinCounter;
	public bool gameRunning = false;

	// Use this for initialization
	void Awake () 
	{
		coinCounter = GameObject.Find("CoinCount").GetComponent<CoinCounter>();
		livesCounter = GameObject.Find("LivesCount").GetComponent<LivesCounter>();
		coins = GameObject.FindGameObjectsWithTag("Coin");
		totalCoins = coins.Length;
	}
	
	// Update is called once per frame
	void Update () 
	{
		int collectedCoins = coinCounter.coinCount;

		livesCounter.extraLives = collectedCoins / totalCoins;
		if (livesCounter.totalLives < 0)
		{
			print("GAME OVER!");
		}

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
