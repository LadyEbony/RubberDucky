﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillUrchin : MonoBehaviour {

	public GameController gameController;
	public StageData stageData;

	void Awake()
	{
		//gameController = GameObject.FindGameObjectWithTag ("GameController").GetComponent(typeof(GameController)) as GameController;
		stageData = gameObject.GetComponentInParent(typeof(StageData)) as StageData;
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
			stageData.DucksKilled++;
			coll.gameObject.SetActive(false);	
		}
	}
}
