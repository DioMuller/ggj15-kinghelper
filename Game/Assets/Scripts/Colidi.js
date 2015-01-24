#pragma strict

    var direcao = 1;

	// Use this for initialization
	function Start () {
	
	}
	
	// Update is called once per frame
	function Update () {
        transform.position.y = transform.position.y + 0.03 * direcao;
        transform.position.x = transform.position.x + 0.01 * direcao;
	}

    function OnTriggerEnter2D (Collider2D)
    {
        //Destroy(other.gameObject);
        //gameObject.;
        Debug.Log ("deu");
        direcao = direcao * -1;
        transform.rotation.x = transform.rotation.x * -1;
    }