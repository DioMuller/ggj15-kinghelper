using UnityEngine;
using System.Collections;

public class RepeatingBackground : MonoBehaviour
{
	public float Speed = 10.0f;
	private Vector2 _offset;

	void Awake()
	{
		_offset = renderer.sharedMaterial.GetTextureOffset("_MainTex");
	}

	void Update()
	{
		float x = Mathf.Repeat(Time.deltaTime*Speed, transform.localScale.x);
		_offset.x += x;
		renderer.sharedMaterial.SetTextureOffset("_MainTex", _offset);

	}

	void OnDisable()
	{
		renderer.sharedMaterial.SetTextureOffset("_MainTex", _offset);
	}
}
