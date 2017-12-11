using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndTrigger : MonoBehaviour {
    [SerializeField]
    private Image image;
    [SerializeField]
    private float fadeSpeed = 5.2f;
    private AudioSource audioSource;
    private bool hasTriggered = false;
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.name);
        
        if (!hasTriggered)
        {
            image.enabled = true;
            image.canvasRenderer.SetAlpha(0.0f);
            audioSource.Play();
            image.CrossFadeAlpha(255, fadeSpeed, false);
            hasTriggered = true;
        }
        StartCoroutine("WaitThenLoad");
    }
    //image.CrossFadeAlpha(255, 4, false);
    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    IEnumerator WaitThenLoad()
    {
        yield return new WaitForSeconds(fadeSpeed);
        SceneManager.LoadScene("EndScene");
    }
}
