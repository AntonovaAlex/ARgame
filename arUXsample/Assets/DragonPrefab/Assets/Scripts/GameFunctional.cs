using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameFunctional : MonoBehaviour {

	//public AudioSource attackSound;
	public GameObject dragon;
	public AudioSource attackSound;

	//public Button startButton;
	public GameObject startButton;

	public GameObject attackButton;
	public GameObject scrollbarGame;
	public GameObject timerGame;
	public GameObject castleLifebarUI;

	public GameObject levelTime;

	public GameObject spawnObject;


	//public float range = 100f; 

	public void Attack()
	{
		attackSound.Play();

		GameObject bullet = Instantiate(Resources.Load("bulletdr", typeof(GameObject))) as GameObject;
		Rigidbody rb = bullet.GetComponent<Rigidbody>();
		//bullet.transform.rotation = dragon.transform.rotation;
		bullet.transform.rotation = Quaternion.Euler(0, 90, 0);
		//bullet.transform.position = dragon.transform.position;
		//bullet.transform.position = new Vector3(dragon.transform.position.x - 0.5f, dragon.transform.position.y + 0.8f, dragon.transform.position.z);
		//bullet.transform.position = new Vector3(0.7816f, -0.1461f, 2.856f);


		//bullet.transform.position = new Vector3(dragon.transform.position.x, dragon.transform.position.y + 0.15f, dragon.transform.position.z);
		bullet.transform.position = new Vector3(dragon.transform.position.x -0.09f, dragon.transform.position.y + 0.06f, dragon.transform.position.z - 0.0f);

		//bullet.transform.position -= new Vector3(1, 0, 0);
		//rb.AddForce(dragon.transform.forward * 500f);



		rb.AddForce(dragon.transform.forward * 50f);

		//ShootTarget();

		Destroy(bullet, 0.2f);
	}

	public void GameOn()
	{
		//startButton.enabled = false;
		startButton.SetActive(false);

		attackButton.SetActive(true);
		scrollbarGame.SetActive(true);
		timerGame.SetActive(true);
		castleLifebarUI.SetActive(true);
		levelTime.SetActive(true);
		spawnObject.SetActive(true);


	}

	//public void ShootTarget()
	//{
	//	RaycastHit hit;
	//	if (Physics.Raycast(player_cam.transform.position, player_cam.transform.forward, out hit, range))
	//	{
	//		Debug.Log(hit.transform.name);
	//	}
	//}
}
