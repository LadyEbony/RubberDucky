using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuckConvo : MonoBehaviour
{
	public GameObject Activate;
	void Start()
	{
		Activate.SetActive (false);
	}

	void Update()
	{
		if (Input.GetButton("Submit_Base"))
		{
			gameObject.SetActive (false);
			Activate.SetActive (true);
		}
	}

}
