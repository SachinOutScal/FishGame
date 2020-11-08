using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Player;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI; 
public class UIController : MonoBehaviour
{
    public int score;
    [SerializeField]Text scoreTxt;
    [SerializeField]GameObject GameOverDisplay;
    [SerializeField] Text finalScore;
    [SerializeField] Button Quit; 

    // Start is called before the first frame update
    void Start()
    {
        GameOverDisplay.SetActive(false);

        score = 0; 
    }

    public void InGameUpdate()
    {
        score = score + 10;
        if (score >= 300)
            GameEndDisplay();
        scoreTxt.text = "SCORE : " + score; 

    }

    public void GameEndDisplay()
    {

        GameOverDisplay.SetActive(true);
        finalScore.text = "FINAL SCORE"+ score; 

    }

    public void OnQuitPressed()
    {

        SceneManager.LoadScene(0); 

    }
}
