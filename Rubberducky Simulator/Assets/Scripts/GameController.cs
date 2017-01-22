using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    private int ResultScenario;

    private int StageIndex;
    private StageData _CurrentStage;
    public StageData CurrentStage
    {
        get
        {
            return _CurrentStage;
        }
    }

    // Use this for initialization
    void Start()
    {
        _CurrentStage = GameObject.Find("Level").GetComponent<StageData>();

        string Scenename = SceneManager.GetActiveScene().name;
        StageIndex = int.Parse(Scenename.Substring(5));

        ResultScenario = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (ResultScenario != 0)
        {
            if (Input.GetButtonDown("Submit_P1") || Input.GetButtonDown("Submit_P2") || Input.GetButtonDown("Submit_Base"))
            {
                TriggerResult();
            }
        }
    }

    /// <summary>
    /// Move to next stage
    /// </summary>
    public void StageWin()
    {
        Debug.Log("Triggered Win");
        GameObject.Find("WinningDuck").SetActive(true);
        ResultScenario = 1;

    }

    /// <summary>
    /// Resetart Current Stage
    /// </summary>
    public void StageRestart()
    {
        Debug.Log("Triggered Reset");
        ResultScenario = 2;

    }

    private void TriggerResult()
    {
        if (ResultScenario == 1)
        {
            SceneManager.LoadScene("Stage" + (StageIndex + 1).ToString());
        }
        else if (ResultScenario == 2)
        {
            SceneManager.LoadScene("Stage" + (StageIndex).ToString());
        }
    }
}
