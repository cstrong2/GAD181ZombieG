using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorehandler : MonoBehaviour
{
    public GameObject currentScore;
    public GameObject highScore;


    private TextMesh currentScoreText;
    private TextMesh highScoreText;
    // Start is called before the first frame update
    void Start()
    {
        currentScoreText = currentScore.GetComponent<TextMesh>();
        highScoreText = highScore.GetComponent<TextMesh>();

        currentScoreText.text = PlayerPrefs.GetString("currentScore");
    }

   
}
