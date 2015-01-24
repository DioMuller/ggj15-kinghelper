#pragma strict

var player : GameObject;

function Start () {
        
}

function Update () {
    transform.position.y = player.transform.position.y;
    transform.position.x = player.transform.position.x;
}