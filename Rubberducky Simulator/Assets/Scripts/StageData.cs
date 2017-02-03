using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageData : MonoBehaviour
{
    public List<GameObject> Ducks = new List<GameObject>();

    [SerializeField]
    private int _MinimumDucksRequired;
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
            GameObject.FindGameObjectWithTag("UI").GetComponent<GameplayUI>().UpdateDucksLeft(MinimumDucksRequired - _DucksSaved);
            if (_DucksSaved >= MinimumDucksRequired)
                GC.StageWin();
        }
    }

    private GameController GC;
    void Awake()
    {
        GC = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
        GameObject[] ducks = GameObject.FindGameObjectsWithTag("Duck");
        Ducks = new List<GameObject>(ducks);
        /*
        foreach(GameObject duck in Ducks)
        {
            Debug.Log(duck.name);
        }
        */
        MinimumDucksRequired = Ducks.Count;

    }

    void Start()
    {
        GameObject.FindGameObjectWithTag("UI").GetComponent<GameplayUI>().UpdateDucksLeft(MinimumDucksRequired);
    }
}
