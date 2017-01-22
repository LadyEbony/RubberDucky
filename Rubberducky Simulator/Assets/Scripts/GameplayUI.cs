using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameplayUI : MonoBehaviour {
    public string StageTag;
    public Text TextElements;
    StageData Data;
	// Use this for initialization
	void Start () {
        Data = GameObject.FindGameObjectWithTag(StageTag).GetComponent<StageData>();
	}
	
	// Update is called once per frame
	void Update () {
        TextElements.text = "Ducks Saved: " + Data.DucksSaved.ToString() + " / " + Data.MinimumDucksRequired.ToString();
        if (Data.DucksSaved == Data.MinimumDucksRequired)
        {
            TextElements.text = "Success! Press A to continue!";
        }
        else if ((Data.Ducks.Count - Data.DucksKilled) < Data.MinimumDucksRequired)
        {
            TextElements.text = "Failure! Press A to restart." ;
        }
	}
}
