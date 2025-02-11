using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinLoadNext : MonoBehaviour
{
    public string nextLevelName = "MainMenu";
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Circle")){
            Debug.Log("Flag hit, next level");
            SceneManager.LoadScene(nextLevelName);
        }
    }
}