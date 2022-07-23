using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject Panel_GameOver;

    private AudioSource loseSound;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        loseSound = GetComponent<AudioSource>();
    }

    // Update is called once per frame

    public void GameOver()
    {
        Time.timeScale = 0;

        Panel_GameOver.SetActive(true);
        loseSound.Play();
    }

    public void RestartGame()
    {
        SceneManager.LoadScene("Game");
    }
    void Update()
    {
        
    }
}
