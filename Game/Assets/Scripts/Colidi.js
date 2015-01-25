#pragma strict

	var direcao = 1;
	var _initialRotation : Quaternion;

	// Use this for initialization
	function Start () {
		_initialRotation = transform.rotation;
	}
	
	// Update is called once per frame
	function Update () {
        transform.position.y = transform.position.y + 0.03 * direcao;
        transform.position.x = transform.position.x + 0.01 * direcao;

        if (transform.position.y > 22){
            transform.position.y = transform.position.y + 0.03 * direcao * -1;   
        } 
        if (transform.position.y < -22){
            transform.position.y = transform.position.y + 0.02 * direcao * -1;   
        } 
        if (transform.position.x > 22){
            transform.position.x = transform.position.x + 0.03 * direcao * -1;   
        } 
        if (transform.position.x < -22){
            transform.position.x = transform.position.x + 0.02 * direcao * -1;   
        }

		transform.rotation = _initialRotation;
	}

    function OnTriggerEnter2D (Collider2D)
    {
        //Destroy(other.gameObject);
        //gameObject.;
        direcao = direcao * -1;
        transform.rotation.x = transform.rotation.x * -1;
    }
