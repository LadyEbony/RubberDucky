using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageData : MonoBehaviour
{
    public List<GameObject> Ducks = new List<GameObject>();

    [SerializeField]
    private int _MinimumDucksRequired = 0;
    public int MinimumDucksRequired
    {
        get { return _MinimumDucksRequired; }
        private set { _MinimumDucksRequired = value; }
    }

    [SerializeField]
    private int _DucksSaved = 0;
    public int DucksSaved
    {
        get { return _DucksSaved; }
        set
        {
            _DucksSaved = value;
            if (_DucksSaved >= MinimumDucksRequired)
                GC.StageWin();
        }
    }

    public int _DucksKilled = 0;
    public int DucksKilled
    {
        get { return _DucksKilled; }
        set
        {
            _DucksKilled = value;
            if (_DucksKilled >= Ducks.Count)
                GC.StageRestart();
        }
    }

    private GameController GC;
    void Awake()
    {
        GC = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
        GameObject[] ducks = GameObject.FindGameObjectsWithTag("Duck");
        Ducks = new List<GameObject>(ducks);
    }
}
