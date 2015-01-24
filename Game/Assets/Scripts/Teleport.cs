using UnityEngine;
using System.Collections;

public class Teleport : MonoBehaviour
{
	public string Map = "";

	void OnTriggerEnter2D(Collider2D other)
	{
		print("Teleport to " + Map);
	}
}
