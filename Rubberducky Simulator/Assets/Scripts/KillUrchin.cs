using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillUrchin : MonoBehaviour
{

	private GameController gameController;

	void Awake()
	{
        gameController = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
	}

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}


	/// <summary>
	/// Collision function called when colliding with another collider
	/// </summary>
	void OnCollisionEnter2D(Collision2D coll)
	{
		if(coll.gameObject.tag == "Duck")
		{
			gameController.CurrentStage.DucksKilled++;
			coll.gameObject.SetActive (false);
		}
	}
}
