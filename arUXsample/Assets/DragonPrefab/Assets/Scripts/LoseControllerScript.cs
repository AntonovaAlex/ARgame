using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseControllerScript : MonoBehaviour {

	// Use this for initialization
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		StartCoroutine(SceneMan());
	}

	IEnumerator SceneMan()
	{
		yield return new WaitForSeconds(5);
		SceneManager.LoadScene(0);
	}
}
