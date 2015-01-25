using UnityEngine;
using UnityEngine.UI;
using System.Collections;

[RequireComponent(typeof(Text))]
public class PrisionersEscaped : MonoBehaviour
{
	private Text _label;
	public CharacterMovement Player;

	// Use this for initialization
	void Start ()
	{
		_label = GetComponent<Text>();
		_label.enabled = false;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Player.Health < 3)
		{
			var escaped = (3 - Player.Health);
			_label.enabled = true;

			if (escaped == 1)
			{
				_label.text = "One Prisioner Has Escaped";	
			}
			else
			{
				_label.text = escaped + " Prisioners Have Escaped";	
			}

			_label.fontSize = escaped*4 + 12;
		}
	}
}
