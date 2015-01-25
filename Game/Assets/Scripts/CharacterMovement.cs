using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(Animator))]
public class CharacterMovement : MonoBehaviour
{

    private Rigidbody2D _rigidbody2D = null;
	private Animator _animator = null;

	public int Health = 3;
	private bool _invunerable = false;

    //private Vector2 posicaoanterior;

	private bool _mirrored = false;

	public float Speed = 10.0f;

	// Use this for initialization
	void Start ()
	{
		_rigidbody2D = GetComponent<Rigidbody2D>();
		_animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () 
	{

		if(Health <= 0) Application.LoadLevel("GameOver");

		var movement = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0.0f);

		_mirrored = movement.x < 0;


		if (_mirrored && transform.localScale.x > 0) transform.localScale = new Vector3(transform.localScale.x * -1, transform.localScale.y, transform.localScale.z);
		if (!_mirrored && transform.localScale.x < 0) transform.localScale = new Vector3(transform.localScale.x * -1, transform.localScale.y, transform.localScale.z);

		var deltaMovement = (movement*Time.deltaTime*Speed);

		_rigidbody2D.MovePosition(transform.position + deltaMovement);

		_animator.SetFloat("Speed", deltaMovement.sqrMagnitude * 100.0f);

    }

    void OnTriggerEnter2D(Collider2D other)
    {
	    if (other.tag == "Enemy" && !_invunerable)
	    {
		    Health--;
		    StartCoroutine(Blink());
	    }
        //Destroy(other.gameObject);
	    //Speed = Speed * -1;
	    //rigidbody2D.AddForce(Vector2.up) ;
	    //Speed = 10;
    }

	IEnumerator Blink()
	{
		_invunerable = true;
		InvokeRepeating("DoBlink", 0.0f, 0.2f);
		yield return new WaitForSeconds(1.0f);
		_invunerable = false;
		CancelInvoke("DoBlink");
		transform.renderer.enabled = true;
	}

	void DoBlink()
	{
		transform.renderer.enabled = !transform.renderer.enabled;
	}
}
