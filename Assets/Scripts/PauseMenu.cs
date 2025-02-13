using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] GameObject pauseMenu;

    public void PauseGame() {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f; // freeze game
    }

    public void ResumeGame() {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
    }

    public void BackToHome(int sceneID) {
        Time.timeScale = 1f;
        SceneManager.LoadScene(sceneID);
    }

    public void RestartGame() {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
