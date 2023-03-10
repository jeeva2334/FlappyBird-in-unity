using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class birdscript : MonoBehaviour {
	public Rigidbody2D myRigidBody2D;
	public float flapStrenght;
	public LogicScript logic;
	public bool birdIsAlive = true;
	
	void Start () {
		logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
	}
	
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space) == true && birdIsAlive){
			myRigidBody2D.velocity = Vector2.up * flapStrenght;
		}
	}

	private void OnCollisionEnter2D(Collision2D collision){
		logic.gameOver();
		birdIsAlive = false;
	}
}
