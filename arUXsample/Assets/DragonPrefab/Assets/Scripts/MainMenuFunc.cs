using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Threading;

public class MainMenuFunc : MonoBehaviour {

	public AudioSource buttonPress;

	public void PlayGame()
	{
		buttonPress.Play();
		RedirectLvl.redirectToLevel = 1;

		SceneManager.LoadScene(1);
	}

	public void QuitGame()
	{
		Application.Quit();
	}
}
