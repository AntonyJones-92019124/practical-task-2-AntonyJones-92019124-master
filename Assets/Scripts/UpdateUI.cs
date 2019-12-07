using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class UpdateUI : MonoBehaviour
{
    [SerializeField]
    public Text levelText; //Level field text Variable
    public int levelCount; //levelCount Variable set to 1

    [SerializeField]
    private Text timerLabel; //timerLabel field text variable

    [SerializeField]
    private Text scoreLabel; //scoreLabel text field variable


    // Use this for initialization
    void Start()
    {
        levelCount = SceneManager.GetActiveScene().buildIndex; //levelCount variable set to active scene
        levelText.text = "Level: " + levelCount.ToString("0"); //set the level text variable to the value of the active scene + 1
        Debug.Log(SceneManager.GetActiveScene().buildIndex + 1); // Debug.log active scene plus 1
    }

    // Update is called once per frame
    void Update()
    {
        timerLabel.text = FormatTime(GameManager.Instance.TimeRemaining); //timerLabel set to format time
        scoreLabel.text = GameManager.Instance.Score.ToString (); // scoreLabel text variable set to Instance of the Score in Game Manager
       
        Debug.Log("Triggered");
        levelText.text = "Level: " + levelCount.ToString("1"); // level text variable allocated levelCount variable value
        Debug.Log(SceneManager.GetActiveScene().buildIndex + 1);
    }

    private string FormatTime(float timeInSeconds)
    {
        return string.Format("{0}:{1:00}", Mathf.FloorToInt(timeInSeconds / 60), Mathf.FloorToInt(timeInSeconds % 60));
    }
}
