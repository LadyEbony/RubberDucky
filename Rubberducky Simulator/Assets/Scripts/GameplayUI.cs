using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameplayUI : MonoBehaviour
{
    [SerializeField]
    private Text Message;

    [SerializeField]
    private Text DucksLeft;

    void Start()
    {
        Message.text = "Get all the ducks into the Drain.";
    }

    public void UpdateDeathMessege()
    {
        Message.text = "Duck Killed!\nPress SELECT to restart stage.";
    }

    public void UpdateWinMessage()
    {
        Message.text = "Success!\n Press Y to go to the next stage.";
    }

    public void UpdateDucksLeft(int value)
    {
        DucksLeft.text = "Ducks Left: " + value.ToString();
    }
}
