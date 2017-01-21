using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitDrain : MonoBehaviour {

	public GameController gameController;
	public StageData stageData;

	void Awake()
	{
		//gameController = GameObject.FindGameObjectWithTag ("GameController").GetComponent(typeof(GameController)) as GameController;
		stageData = gameObject.GetComponentInParent(typeof(StageData)) as StageData;
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
			stageData.DucksSaved++;
			coll.gameObject.SetActive (false);
		}
	}
}
