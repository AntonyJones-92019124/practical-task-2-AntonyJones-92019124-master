using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameManager : Singleton<GameManager>
{

    private float _timeRemaining;

    public float TimeRemaining
    {
        get { return _timeRemaining; } //get and set for timeRemaning
        set { _timeRemaining = value; }
    }

    private int _score;

    public int Score
    {
        get { return _score; }  //get and set for Score
        set { _score = value; }
    }

    private float maxTime = 1 * 60; // In seconds.
    private int currentLevel = 1;

    // Use this for initialization
    void Start()
    {
        TimeRemaining = maxTime; // set TimeRemaning get ans set to maxTime variable
 
    }

    // Update is called once per frame
    [System.Obsolete]
    void Update()
    {
       
        TimeRemaining -= Time.deltaTime;

        if (TimeRemaining <= 0)
        {
            Application.LoadLevel(Application.loadedLevel);
            TimeRemaining = maxTime; //if timeRemaning variable value is less than or equal to 0 reload current level
        }

            if (Score >= 1000)
        {            
            Application.LoadLevel(Application.loadedLevel + 1); //if Score get and set is lessgreater than or equal to 1000 load next level       
        }
    }
}


