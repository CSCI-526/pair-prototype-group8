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

    // Start is called before the first frame update
    void Start()
    {
        levelText.text = level.ToString();
    }

    public void OpenLevelScene() {
        var type = ToggleSwitch.CurrentValue ? "WackyLevel" : "NEW Level ";
        Debug.Log("Current type: " + type);
        SceneManager.LoadScene(type + level.ToString());
    }
}
