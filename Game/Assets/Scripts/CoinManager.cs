using System.Net.Mime;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CoinManager : MonoBehaviour 
{
	public static CoinManager Instance { get; private set; }

	public Text Label;
	public string NextScene;
	public int MaxValue = 8;

	public int Coins { get; private set; }

	void Awake()
	{
		Instance = this;
	}

	void Update()
	{
		Label.text = Coins + "/" + MaxValue;

		if (Coins >= MaxValue)
		{
			Application.LoadLevel(NextScene);
		}
	}

	public void AddCoins(int coins)
	{
		Coins += coins;
	}
}
