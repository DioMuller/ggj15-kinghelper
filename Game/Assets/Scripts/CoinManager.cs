using System.Net.Mime;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CoinManager : MonoBehaviour 
{
	public static CoinManager Instance { get; private set; }

	public Text Label;

	public int Coins { get; private set; }

	void Awake()
	{
		Instance = this;
	}

	void Update()
	{
		Label.text = Coins + "/8";
	}

	public void AddCoins(int coins)
	{
		Coins += coins;
	}
}
