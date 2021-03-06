﻿using UnityEngine;
using System.Collections;

public class CollisonTrigger : MonoBehaviour {
	private BoxCollider2D playerCollider;
	[SerializeField]
	private EdgeCollider2D platformCollider;
	[SerializeField]
	private EdgeCollider2D platformTrigger;
	// Use this for initialization
	void Start () {
		playerCollider = GameObject.Find ("Player").GetComponent<BoxCollider2D> ();
		Physics2D.IgnoreCollision (platformCollider, platformTrigger,true);

	}
	
	// Update is called once per frame
	void OnTriggerEnter2D(Collider2D other){ 
		if (other.gameObject.name == "Player") {
			Physics2D.IgnoreCollision (platformCollider, other, true);
		}
	}
	void OnTriggerExit2D(Collider2D other){
		if (other.gameObject.name == "Player") {
			Physics2D.IgnoreCollision (playerCollider, other, false);
		}
	}
}
