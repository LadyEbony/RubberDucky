using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuckConvo : MonoBehaviour
{
	void Update()
	{
		if (Input.GetButton("Submit_Base"))
		{
            gameObject.SetActive (false);
		}
	}

}
