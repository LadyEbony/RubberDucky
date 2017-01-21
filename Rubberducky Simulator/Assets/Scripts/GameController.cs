using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public List<GameObject> Ducks = new List<GameObject>();

    public int DucksSaved = 0;
    public int DucksKilled = 0;

    private int _CurrentStage = 0;
    public int CurrentStage
    {
        get { return _CurrentStage; }
        private set { _CurrentStage = value; }
    }

    void Awake()
    {
        GameObject[] ducks = GameObject.FindGameObjectsWithTag("Duck");
        Ducks = new List<GameObject>(ducks);
        Debug.Log(Ducks.Count);
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
