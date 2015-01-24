using UnityEngine;
using System.Collections;

public class CoinManager : MonoBehaviour 
{
	public static CoinManager Instance { get; private set; }

	public int Coins { get; private set; }

	void Awake()
	{
		Instance = this;
	}

	public void AddCoins(int coins)
	{
		Coins += coins;
	}

	void OnGUI()
	{
		
	}
}
