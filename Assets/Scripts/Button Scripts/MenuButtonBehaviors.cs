using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtonBehaviors : MonoBehaviour {
    private AudioSource audio;

    public void NavigateToMenu()
    {
        audio.Play();
        SceneManager.LoadScene("StartMenu");
    }
    public void NavigateToCredits()
    {
        audio.Play();
        SceneManager.LoadScene("CreditsScene");
    }
    public void StartGame()
    {
        audio.Play();
        SceneManager.LoadScene("Level1");
    }
    private void Start()
    {
        audio = GetComponent<AudioSource>();
    }
}
