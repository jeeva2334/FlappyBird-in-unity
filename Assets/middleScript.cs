﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class middleScript : MonoBehaviour {
	public LogicScript logic;
	// Use this for initialization
	void Start () {
		logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnTriggerEnter2D(Collider2D collision){
		logic.addScore(1);
	}
}
