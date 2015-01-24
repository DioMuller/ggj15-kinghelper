using UnityEngine;
using System.Collections;

public class Coin : MonoBehaviour
{
	public float Speed = 0.3f;

	void Update()
	{
		//transform.position += Speed*Time.deltaTime * Vector3.left;
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Player")
		{
			GetComponent<AudioSource>().Play();
			CoinManager.Instance.AddCoins(1);
			Destroy(gameObject);
		}

		//transform.position = new Vector3(Random.Range(10f, 20f), Random.Range(-3f, 3f), other.transform.position.z);
	}
}
