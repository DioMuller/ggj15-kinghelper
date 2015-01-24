using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(Animator))]
public class CharacterMovement : MonoBehaviour
{

    private Rigidbody2D _rigidbody2D = null;
	private Animator _animator = null;

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
        //Destroy(other.gameObject);
        Speed = Speed * -1;
        //rigidbody2D.AddForce(Vector2.up) ;
        //Speed = 10;
    }
}
