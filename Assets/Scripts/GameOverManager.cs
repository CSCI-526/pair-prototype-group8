using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour
{
    public GameObject gameOverUI;
    public GameObject gamePassUI;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowGameOver() {
        Time.timeScale = 0f;
        gameOverUI.SetActive(true);
    }

    public void ShowPassGame() {
        Time.timeScale = 0f;
        gamePassUI.SetActive(true);
    }

    public void LoadNextLevel() {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
