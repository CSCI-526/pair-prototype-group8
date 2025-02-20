using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour
{
    private int starForLevel = 0;
    public GameObject gameOverUI;
    public GameObject gamePassUI;
    public GameObject zeroGrid;
    public GameObject oneGrid;
    public GameObject twoGrid;
    public GameObject allGrid;

    public TimerScript timer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void ShowGameOver() {
        Time.timeScale = 0f;
        gameOverUI.SetActive(true);
    }

    public void ShowPassGame() {
        timer = FindObjectOfType<TimerScript>();
        Time.timeScale = 0f;
        gamePassUI.SetActive(true);
        starForLevel = timer.GetStarCount();
        SpawnStar(starForLevel);
        Debug.Log("----- star acquired: " + starForLevel.ToString());
        if(starForLevel > PlayerPrefs.GetInt("stars" + LevelSelectionManager.type + LevelSelectionManager.currentLevel.ToString(), 0)) {
            PlayerPrefs.SetInt("stars" + LevelSelectionManager.type + LevelSelectionManager.currentLevel.ToString(), starForLevel);
        }
    }

    public void LoadNextLevel() {
        Time.timeScale = 1f;
        LevelSelectionManager.currentLevel += 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    private void SpawnStar(int starCount)
    {
        zeroGrid.SetActive(starCount == 0);
        oneGrid.SetActive(starCount == 1);
        twoGrid.SetActive(starCount == 2);
        allGrid.SetActive(starCount == 3);
    }
}
