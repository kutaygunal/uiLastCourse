using UnityEngine;
using System.Collections;

public class Coin : MonoBehaviour 
{
	
	void Awake()
	{

	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.gameObject.tag == "Player")
			print ("You picked up a coin!");
		
		//Set the coin to inactive
		gameObject.SetActive(false);
	}

}
