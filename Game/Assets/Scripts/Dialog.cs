using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Dialog : MonoBehaviour
{
	private int _current = -1;
	private bool _pressed = false;

	public string[] Text;
	public string NextLevel = "";
	public Text DialogComponent;

	void Start()
	{
		NextDialog();
	}

	void Update()
	{
		if (Input.GetButton("Jump"))
		{
			if (!_pressed)
			{
				NextDialog();
				_pressed = true;	
			}
		}
		else
		{
			_pressed = false;
		}
	}

	private void NextDialog()
	{
		_current++;

		if (_current > Text.Length)
		{
			Application.LoadLevel(NextLevel);
		}
		else
		{
			DialogComponent.text = Text[_current];	
		}
	}
}
