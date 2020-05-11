using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CastleHealth : MonoBehaviour {


	public Image[] lifes;

	public GameObject dark;
	//public Sprite oneLife;

	

	private int damage = 3;


	

	void Start()
	{
		
	}

	public void CastleDam()
	//public IEnumerator CastleDam()
	{
		damage -= 1;
		Debug.Log("Damage!2");

		if (damage == 2)
		{
			lifes[2].enabled = false;
		}

		if (damage == 1)
		{
			lifes[1].enabled = false;
		}

		if (damage == 0)
		{
			dark.SetActive(true);
			lifes[0].enabled = false;

			
			//yield return new WaitForSeconds(5);
			//Time.timeScale = 0;
			SceneManager.LoadScene(3);

		}
	
	}
}
