using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreText : MonoBehaviour
{
    public static ScoreText Instance;
    [SerializeField] private TMP_Text scoreText;
    private int points;
    // Start is called before the first frame update
    void Start()
    {
        if (Instance == null) //If no text score exists...
        {
            Instance = this; //Assign this object as the global instance. "this" refers to the current ScoreText component on this GameObject.
        }
        else //Prevents multiple score managers, avoids duplicate scores, and avoids UI bugs. If a second text score appears, then delete it.
        {
            Destroy(gameObject);
        }
        UpdateScoreText(); //Once game starts, show the current score ("Points: 0" at the start) right away. "private int points;" is set to 0 by default.
    }
    public void AddPoint()
    {
        points++;
        UpdateScoreText();
    }
    private void UpdateScoreText()
    {
        scoreText.text = $"Points: {points}"; //$"..." - String Interpolation. Equivalent to "Points: " + points. {points} inserts the value of points.
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
