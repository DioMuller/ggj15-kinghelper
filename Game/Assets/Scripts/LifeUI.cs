using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class LifeUI : MonoBehaviour
{
	public int HealthLevel;
	public Image JailImage;
	public CharacterMovement Player;
	
	// Update is called once per frame
	void Update () 
	{
		if (Player.Health < HealthLevel && JailImage.enabled)
		{
			JailImage.enabled = false;
		}
	}
}
