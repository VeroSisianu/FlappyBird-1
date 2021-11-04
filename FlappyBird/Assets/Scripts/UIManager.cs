using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public GameObject StartUI;
    public GameObject RestartUI;
    public GameObject FlappyBirdUI;
    public Text ScoreText;
    public Text FinalScore;


    void Update()
    {
        if(StateManager.State == StateManager.States.Play)
        {
            if(!ScoreText.gameObject.activeSelf)
            {
                ScoreText.gameObject.SetActive(true);
            }
            ScoreText.text = ScoreManager.Score.ToString();
        }
        if(StartUI.activeSelf)
            if(Input.GetMouseButtonDown(0))
            {
                StateManager.State = StateManager.States.Play;
                StartUI.SetActive(false);
                FlappyBirdUI.SetActive(false);
            }
        if (StateManager.State == StateManager.States.End)
        {
            if(ScoreText.gameObject.activeSelf)
            { 
                ScoreText.gameObject.SetActive(false);
            }
            if (!FinalScore.gameObject.activeSelf)
            {
                FinalScore.text = "Final Score : " + ScoreManager.Score;
                FinalScore.gameObject.SetActive(true);
            }
            if (!RestartUI.activeSelf)
            {
                RestartUI.SetActive(true);
            }
            if (Input.GetMouseButtonDown(0))
            {
                RestartUI.SetActive(false);
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }
    }
}
