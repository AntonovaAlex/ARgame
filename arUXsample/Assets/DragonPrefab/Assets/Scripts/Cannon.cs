using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cannon : MonoBehaviour {

	//public GameObject cannons;


	

	// Use this for initialization
	void Start () {
		Attack();
	}
	
	// Update is called once per frame
	void Update () {

		//Attack();
		//executeWait();
	}

	//public AudioSource attackSound;
	//public GameObject cannon;

	//public float range = 100f; 

	public void Attack()
	{
		//attackSound.Play();
		//yield return new WaitForSeconds(3);
		//GameObject bullet = Instantiate(Resources.Load("eBullet", typeof(GameObject))) as GameObject;
		//Rigidbody rb = bullet.GetComponent<Rigidbody>();
		Rigidbody rb = GetComponent<Rigidbody>();
		//bullet.transform.rotation = dragon.transform.rotation;



		//transform.rotation = Quaternion.Euler(0, 90f, 0);
		transform.rotation = Quaternion.identity;

		//bullet.transform.position = dragon.transform.position;
		//bullet.transform.position = new Vector3(cannon.transform.position.x - 0.5f, cannon.transform.position.y + 0.8f, cannon.transform.position.z);
		//bullet.transform.position -= new Vector3(1, 0, 0);
		//rb.AddForce(dragon.transform.forward * 500f);
		rb.AddForce(transform.forward * 30f);

		//ShootTarget();

		Destroy(gameObject, 1.5f);
	}

	//IEnumerator SceneMan()
	//{
	//	yield return new WaitForSeconds(3);
	//	//SceneManager.LoadScene(5);
	//}

	private void executeWait()
	{
		Debug.Log("wait start");
		StartCoroutine(Wait(50.0f));
		Debug.Log("This gets called after starting the Coroutine");

	}

	private IEnumerator Wait(float seconds)
	{
		Debug.Log("waiting");
		yield return new WaitForSeconds(seconds);
		Debug.Log("wait end");
	}
}
