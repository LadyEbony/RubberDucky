using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public List<StageData> StageList = new List<StageData>();

    private int StageIndex = 0;
    private StageData _CurrentStage;
    public StageData CurrentStage
    {
        get
        {
            return StageList[StageIndex];
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
        StageIndex++;
    }

    /// <summary>
    /// Resetart Current Stage
    /// </summary>
    public void StageRestart()
    {

    }
}
