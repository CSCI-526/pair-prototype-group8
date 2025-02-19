using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinLoadNext : MonoBehaviour
{
    public string nextLevelName = "MainMenu";
    public GameOverManager gameOverManager;
    // Start is called before the first frame update
    void Start()
    {
        if(gameOverManager == null) {
            gameOverManager = FindObjectOfType<GameOverManager>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Circle")){
            Debug.Log("Flag hit, next level");
            if (gameOverManager) {
                gameOverManager.ShowPassGame();
            } else {
                // SceneManager.LoadScene(nextLevelName);
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag.Equals("Circle")){
            Debug.Log("Flag intersected, next level");
            if (gameOverManager) {
                gameOverManager.ShowPassGame();
            } else {
                // SceneManager.LoadScene(nextLevelName);
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
        }
    }
}