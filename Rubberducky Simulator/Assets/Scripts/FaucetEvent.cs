using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FaucetEvent : MonoBehaviour {

    public GameObject RippleObject;
    private float TimeRecord;
    private float TimeMax = 1;

    [SerializeField]
    float x_change = 0.15f;
    [SerializeField]
    float y_change = 0.19f;

    // Use this for initialization
    void Start () {
        TimeRecord = 0.0f;

	}
	
	// Update is called once per frame
	void Update ()
    {
        TimeRecord += Time.deltaTime;
        if (TimeRecord >= TimeMax)
        {
            CreateWave();
            TimeRecord = 0.0f;
        }
    }
    private void CreateWave()
    {
        float mousex = transform.position.x + x_change;
        float mousey = transform.position.y + y_change;
        //Debug.Log("x: " + mousex + "| y: " + mousey);
        GameObject wave = (GameObject)Instantiate(RippleObject);
        Transform waveb = wave.GetComponent<Transform>();
        //waveb.transform.SetParent(this.transform);
        waveb.transform.localPosition = new Vector3(mousex, mousey, 0);
        waveb.transform.localScale = new Vector3(1, 1, 1);
    }
}
