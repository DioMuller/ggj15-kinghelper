using UnityEngine;
using System.Collections;

public class FakeLoading : MonoBehaviour
{

	public string NextLevel = "";

	// Use this for initialization
	void Start ()
	{
		StartCoroutine(LoadAfterDelay());
	}

	public IEnumerator LoadAfterDelay()
	{
		yield return new WaitForSeconds(3.0f);
		Application.LoadLevel(NextLevel);
	}
}
