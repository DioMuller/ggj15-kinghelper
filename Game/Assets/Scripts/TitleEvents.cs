using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using System.Collections;

public class TitleEvents : MonoBehaviour
{
	public Canvas MainCanvas = null;
	public Canvas CreditsCanvas = null;
	public string GameSceneName = "";

	public EventSystem System;

	public Button[] TitleButtons;
	public Button[] CreditsButtons;

	public void OnNewGameClick()
	{
		Application.LoadLevel(GameSceneName);
	}

	public void OnQuit()
	{
		Application.Quit();
	}

	public void OnCreditsClick()
	{
		MainCanvas.enabled = false;
		CreditsCanvas.enabled = true;

		foreach (Button button in TitleButtons)
		{
			button.interactable = false;
		}

		foreach (Button button in CreditsButtons)
		{
			button.interactable = true;
		}

		System.SetSelectedGameObject(CreditsButtons[0].gameObject);
	}

	public void OnBackClick()
	{
		MainCanvas.enabled = true;
		CreditsCanvas.enabled = false;

		foreach (Button button in TitleButtons)
		{
			button.interactable = true;
		}

		foreach (Button button in CreditsButtons)
		{
			button.interactable = false;
		}

		System.SetSelectedGameObject(TitleButtons[0].gameObject);
	}
}
