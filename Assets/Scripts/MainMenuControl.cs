using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuControl : MonoBehaviour
{
    public GameObject levelPanel;
    public GameObject menuButton;
    public GameObject title;
    // // Start is called before the first frame update
    void Start()
    {
        if(LevelSelectionManager.ShowLevelSelector) {
            levelPanel.SetActive(true);
            menuButton.SetActive(false);
            title.SetActive(false);
            LevelSelectionManager.ShowLevelSelector = false;
        }
    }

    public void StartGame() {
        SceneManager.LoadSceneAsync(1);
    }

    public void ExitGame() {
        Application.Quit();
    }
}
