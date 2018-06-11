using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {
    public GameObject menu;
    public GameObject credits;
    public GameObject howToPlay;
    public GameObject play;
    public GameObject titel;
    public GameObject gameOver;

    public void LoadLevel(int i) {
        SceneManager.LoadScene(i);
    }

    public void Credits() {
        menu.SetActive(false);
        credits.SetActive(true);
    }

    public void HowToPlay()
    {
        menu.SetActive(false);
        howToPlay.SetActive(true);
    }

    public void Terug() {
        howToPlay.SetActive(false);
        credits.SetActive(false);
        menu.SetActive(true);
    }

    public void Play() {
        menu.SetActive(false);
        play.SetActive(true);
        titel.SetActive(false);
    }
    public void Restart()
    {
        play.SetActive(true);
        gameOver.SetActive(false);
        titel.SetActive(false);
    }
}
