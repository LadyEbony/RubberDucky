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
	void OnCollisionEnter2D(Collision2D coll)
	{
		if(coll.gameObject.tag == "Duck")
		{
            gameController.CurrentStage.DucksSaved++;
            coll.gameObject.SetActive(false);
            this.GetComponent<AudioSource>().Play();
            //StartCoroutine("Shrink", coll.gameObject);
		}
	}

    IEnumerator Shrink(GameObject obj)
    {
        while (obj.transform.localScale.x > 0 && obj.transform.localScale.y > 0)
        {
            obj.transform.localScale = new Vector3(obj.transform.localScale.x - 0.1f, obj.transform.localScale.y - 0.1f, obj.transform.localScale.z);
            yield return new WaitForSeconds(0.1f);
        }
        obj.SetActive(false);
    }
}
