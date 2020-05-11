using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GlobalTimer : MonoBehaviour {

	public GameObject timeDisplay;
	public bool isTakingTime = false;
	public int theSeconds = 59;

	public GameObject dark;


	// Update is called once per frame
	void Update () {
		if (isTakingTime == false)
		{
			StartCoroutine(SubtractSecond());
		}

		if (theSeconds == 0)
		{
			dark.SetActive(true);
			SceneManager.LoadScene(2);
		}
	}

	IEnumerator SubtractSecond()
	{
		isTakingTime = true;
		theSeconds -= 1;
		if (theSeconds > 9)
		{
			timeDisplay.GetComponent<Text>().text = "" + theSeconds;
		}
		if (theSeconds < 9)
		{
			timeDisplay.GetComponent<Text>().text = "0" + theSeconds;
		}
		yield return new WaitForSeconds(1);
		isTakingTime = false;
	}
}
