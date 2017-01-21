using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour {

    // Use this for initialization
    // Update is called once per frame

    string[] DucksAllowed;
	void Update () {
		
	}
    void OnTriggerEnter2D(Collision2D col)
    {
        foreach(string duck in DucksAllowed)
        {
            if (col.gameObject.GetComponent<Duck>().DuckID == duck)
            {
                gameObject.SetActive(false);
            }
        }
    }

}
