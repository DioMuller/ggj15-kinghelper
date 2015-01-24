using UnityEngine;
using System.Collections;

public class Colidi : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D (Collider2D other){
        //Destroy(other.gameObject);
        Destroy(gameObject);
        Debug.Log ("deu");
    }
}
