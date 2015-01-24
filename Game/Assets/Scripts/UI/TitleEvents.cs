using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TitleEvents : MonoBehaviour
{
	public Canvas MainCanvas = null;
	public Canvas CreditsCanvas = null;
	public string GameSceneName = "";

	public void OnNewGameClick()
	{
		Application.LoadLevel(GameSceneName);
	}

	public void OnCreditsClick()
	{
		MainCanvas.enabled = false;
		CreditsCanvas.enabled = true;
	}

	public void OnBackClick()
	{
		MainCanvas.enabled = true;
		CreditsCanvas.enabled = false;
	}
}
