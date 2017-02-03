using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillUrchin : MonoBehaviour
{

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
            StartCoroutine(coll.gameObject.GetComponent<Duck>().Death());
        }
	}
}
