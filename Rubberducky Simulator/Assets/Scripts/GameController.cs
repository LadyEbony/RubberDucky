using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public Dictionary<int, GameObject> Players = new Dictionary<int, GameObject>();

    private int _CurrentStage = 0;
    public int CurrentStage
    {
        get { return _CurrentStage; }
        private set { _CurrentStage = value; }
    }

    void Awake()
    {
        GameObject[] players = GameObject.FindGameObjectsWithTag("Player");
        int i = 0;
        foreach (GameObject player in players)
        {
            Players.Add(i, player);
            ++i;
        }
    }

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    /// <summary>
    /// Move to next stage
    /// </summary>
    public void StageWin()
    {

    }

    /// <summary>
    /// Lose stage, and reset current stage
    /// </summary>
    public void StageLost()
    {

    }
}
