using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEditor;
using System.IO;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    private int ResultScenario;

    private int MaxStage;

    private int StageIndex;

    private bool StageDone = false;

    public StageData CurrentStage
    {
        get
        {
			return GetComponent<StageData>();
        }
    }

    // Use this for initialization
    void Start()
    {
        string Scenename = SceneManager.GetActiveScene().name;
        StageIndex = int.Parse(Scenename.Substring(5));

        //MaxStage = // searches the current directory and sub directory
        DirectoryInfo dir = new DirectoryInfo(Application.dataPath + "/Scenes/Stages/");
        MaxStage = dir.GetFiles("*.unity").Length;

        //Debug.Log(MaxStage);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Back_Base"))
        {
            SceneManager.LoadScene("Stage" + (StageIndex).ToString());
        }
        else if (StageDone && Input.GetButtonDown("Y_Base"))
        {
            if (StageIndex == MaxStage - 1)
                SceneManager.LoadScene("TitleMenu");
            else
                SceneManager.LoadScene("Stage" + (StageIndex + 1).ToString());
        }
        else if (Input.GetButtonDown("Rb_Base"))
        {
            if (StageIndex == MaxStage - 1)
                SceneManager.LoadScene("TitleMenu");
            else
                SceneManager.LoadScene("Stage" + (StageIndex + 1).ToString());
        }
        else if (Input.GetButtonDown("Lb_Base"))
        {
            if (StageIndex == 0)
            {
                SceneManager.LoadScene("TitleMenu");
            }
            else
            {
                SceneManager.LoadScene("Stage" + (StageIndex - 1).ToString());
            }

        }
    }

    /// <summary>
    /// Move to next stage
    /// </summary>
    public void StageWin()
    {
        GameObject.FindGameObjectWithTag("UI").GetComponent<GameplayUI>().UpdateWinMessage();
        StageDone = true;
    }
}
