using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(Animator))]
public class CharacterRunner : MonoBehaviour
{
	private Rigidbody2D _rigidbody2D = null;
	private Animator _animator = null;
	private float _grounded = 0.0f;

	private bool _mirrored = false;

	public float Speed = 10.0f;
	public float JumpForce = 100.0f;
	public float JumpMaxPressTime = 0.3f;

	// Use this for initialization
	void Start ()
	{
		_rigidbody2D = GetComponent<Rigidbody2D>();
		_animator = GetComponent<Animator>();

		_animator.SetFloat("Speed", 1.0f);
	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{
		var movement = Input.GetAxis("Horizontal");

		_mirrored = movement < 0;


		if (_mirrored && transform.localScale.x > 0) transform.localScale = new Vector3(transform.localScale.x * -1, transform.localScale.y, transform.localScale.z);
		if (!_mirrored && transform.localScale.x < 0) transform.localScale = new Vector3(transform.localScale.x * -1, transform.localScale.y, transform.localScale.z);

		var jumpSpeed = _rigidbody2D.velocity.y;

		if (_grounded < JumpMaxPressTime)
		{
			if (Input.GetButton("Jump"))
			{
				jumpSpeed = JumpForce;
				_grounded += Time.fixedDeltaTime;
			}
			else if(_grounded > 0.01f)
			{
				_grounded = JumpMaxPressTime;
			}
		}

		_rigidbody2D.velocity = new Vector2(movement * Speed, jumpSpeed);
	}

	void OnCollisionEnter2D(Collision2D collision)
	{
		if(collision.transform.tag == "Ground")
			_grounded = 0.0f;
		else
		{
			print("Error Collision.");
		}
	}
}
