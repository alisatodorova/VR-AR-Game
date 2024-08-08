using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public CanvasGroup InstructionsPanel;
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void Instructions()
    {
        InstructionsPanel.alpha = 1;
        InstructionsPanel.blocksRaycasts = true;
    }
    public void Back()
    {
        InstructionsPanel.alpha = 0;
        InstructionsPanel.blocksRaycasts = false;
    }
    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
