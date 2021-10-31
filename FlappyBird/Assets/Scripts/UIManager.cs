using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public GameObject StartUI;
    public GameObject RestartUI;

    void Update()
    {
        if(StartUI.activeSelf)
            if(Input.GetMouseButtonDown(0))
            {
                StateManager.State = StateManager.States.Play;
                StartUI.SetActive(false);
            }
        if(StateManager.State == StateManager.States.End)
        {   
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
