using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipeSpawner : MonoBehaviour {

	// Use this for initialization
	public GameObject pipe;
	public float spawnRate = 6;
	private float timer = 0;
	public float height = 10;

	void Start () {
		spawnPipe();
	}
	
	// Update is called once per frame
	void Update () {
		if(timer < spawnRate){
			timer += Time.deltaTime;
		}else{
			spawnPipe();
			timer = 0;
		}
	}

	void spawnPipe(){
		float lowestPoint = transform.position.y - height;
		float highestPoint = transform.position.y + height;

		Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestPoint,highestPoint),0), transform.rotation);
	}
}
