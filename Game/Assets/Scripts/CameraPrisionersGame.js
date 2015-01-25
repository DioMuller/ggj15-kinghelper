#pragma strict

var player : GameObject;

function Start () {
        
}

function Update () {
	transform.position.y = player.transform.position.y - 5;
    transform.position.x = player.transform.position.x;
}
