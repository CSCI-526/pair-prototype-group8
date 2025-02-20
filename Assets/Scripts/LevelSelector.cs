using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class LevelSelector : MonoBehaviour
{
    public int level;
    public TextMeshProUGUI levelText;

    public GameObject zeroStar;
    public GameObject oneStar;
    public GameObject twoStar;
    public GameObject threeStar;

    private GameObject currentStar;

    // Start is called before the first frame update
    void Start()
    {
        levelText.text = level.ToString();
        int starCount = PlayerPrefs.GetInt("stars" + LevelSelectionManager.type + level.ToString(), 0);
        Debug.Log("star count: " + starCount);
        SpawnStar(starCount);
    }

    private void SpawnStar(int starCount)
    {
        zeroStar.SetActive(starCount == 0);
        oneStar.SetActive(starCount == 1);
        twoStar.SetActive(starCount == 2);
        threeStar.SetActive(starCount == 3);
    }

    public void OpenLevelScene() {
        // var type = ToggleSwitch.CurrentValue ? "WackyLevel" : "NEW Level ";
        LevelSelectionManager.currentLevel = level;
        Debug.Log("current select: " + LevelSelectionManager.currentLevel);
        SceneManager.LoadScene(LevelSelectionManager.type + level.ToString());
    }
}
