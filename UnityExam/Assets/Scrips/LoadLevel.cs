using System;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LoadLevel : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player" && SceneManager.GetActiveScene().buildIndex == 1)
        {
            SceneManager.LoadScene("Level2", LoadSceneMode.Single);
        }
        if (other.tag == "Player" && SceneManager.GetActiveScene().buildIndex == 2)
        {
            SceneManager.LoadScene("Level1", LoadSceneMode.Single);
        }
    }
}
