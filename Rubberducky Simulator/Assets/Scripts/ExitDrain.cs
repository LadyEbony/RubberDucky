using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitDrain : MonoBehaviour {

	private int playerCount;
	public GameController gameController;

	void Awake()
	{
		playerCount = 0;
		//gameController = GameObject.FindGameObjectWithTag ("GameController").GetComponent(typeof(GameController)) as GameController;
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collision2D coll)
	{
		if(coll.gameObject.tag == "Player")
				{
					playerCount++;
					if (playerCount == gameController.Players.Count)
						gameController.StageWin ();
				}
	}

	void OnTriggerExit2D(Collision2D coll)
	{
		if (coll.gameObject.tag == "Player") 
		{
			playerCount--;
		}
	}

//	void OnCollisionEnter2D(Collision2D coll)
//	{
//		if(coll.gameObject.tag == "Player")
//		{
//			playerCount++;
//			if (playerCount == gameController.Players.Count)
//				gameController.StageWin ();
//		}
//	}
//
//	void OnCollisionExit2D(Collision2D coll)
//	{
//		if (coll.gameObject.tag == "Player") 
//		{
//			playerCount--;
//		}
//	}
}
