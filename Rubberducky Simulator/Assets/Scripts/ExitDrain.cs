using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitDrain : MonoBehaviour {

	private GameController gameController;

	void Awake()
	{
        gameController = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	/// <summary>
	/// Trigger function called when a "duck" touches the ExitDrain trigger
	/// </summary>
	void OnTriggerEnter2D(Collider2D coll)
	{
		if(coll.gameObject.tag == "Duck")
		{
            gameController.CurrentStage.DucksSaved++;
			coll.gameObject.SetActive (false);
		}
	}
}
