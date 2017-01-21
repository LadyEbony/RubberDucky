using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillUrchin : MonoBehaviour {

	private PolygonCollider2D urchinCollider;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	void OnCollisionEnter2D(Collision2D coll)
	{
		if(coll.gameObject.tag == "Player")
		{
			coll.gameObject.SetActive(false);	//"kill" Player object
			//Game Over
		}
	}
}
