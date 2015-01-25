using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TitleEvents : MonoBehaviour
{
	public Canvas MainCanvas = null;
	public Canvas CreditsCanvas = null;
	public string GameSceneName = "";
	public string QuickGameSceneName = "";

	public void OnNewGameClick()
	{
		Application.LoadLevel(GameSceneName);
	}

	public void OnQuickStartClick()
	{
		Application.LoadLevel(QuickGameSceneName);
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
