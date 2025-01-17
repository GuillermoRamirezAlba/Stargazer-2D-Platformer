﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelExit : MonoBehaviour {

    [SerializeField] float LevelLoadDelay = 1f;
    [SerializeField] float LevelExitSlowMo = .2f;
    public Animator animator;
    private int currentSceneIndex;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        StartCoroutine(LoadNextLevel());
        // LoadNextLevel();
    }

    IEnumerator LoadNextLevel()
    // private void LoadNextLevel()
    {
        animator.SetTrigger("FadeOut");
        // Time.timeScale = LevelExitSlowMo;
        yield return new WaitForSecondsRealtime(LevelLoadDelay);
        // Time.timeScale = 1f;
        // animator.SetTrigger("FadeOut");
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        // animator.SetTrigger("FadeOut");
        if (currentSceneIndex == 14 || currentSceneIndex == 15 || currentSceneIndex == 16)
        {
            SceneManager.LoadScene(17);
        }
        else
        {
            SceneManager.LoadScene(currentSceneIndex + 4);
        }
    }

    public void OnFadeComplete ()
	{
		// SceneManager.LoadScene(currentSceneIndex+1);
	}
}
