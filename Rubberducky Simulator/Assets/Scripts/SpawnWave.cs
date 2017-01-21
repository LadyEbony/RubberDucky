using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnWave : MonoBehaviour {

    public GameObject RippleObject;
   
	// Use this for initialization
	void Start () {
        Debug.Log("Script: SpawnWave has started running.");
    }
	
	// Update is called once per frame
	//void Update () {
	//	if (Input.GetMouseButtonDown(0))
 //       {
 //           CreateWave();
 //       }
	//}

    private void CreateWave()
    {
        float mousex = Input.mousePosition.x;
        float mousey = Input.mousePosition.y;
        //Debug.Log("x: " + mousex + "| y: " + mousey);
        GameObject wave = (GameObject)Instantiate(RippleObject);
        Transform waveb = wave.GetComponent<Transform>();
        waveb.transform.SetParent(this.transform);
        waveb.transform.localPosition = new Vector3(mousex, mousey, 0);
        waveb.transform.localScale = new Vector3(1, 1, 1);
    }
}
