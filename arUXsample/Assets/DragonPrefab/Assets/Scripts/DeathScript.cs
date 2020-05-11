using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathScript : MonoBehaviour {

	//public GameObject dragon;

	//// Use this for initialization
	//void Start () {
		
	//}
	
	//// Update is called once per frame
	//public void Death () {
	//	if (dragon == null)
	//	{
	//		SceneManager.LoadScene(4);
	//	}
	//}

	public GameObject explosion;


	//DeathScript death;

	//private Target target;



	void OnTriggerEnter(Collider other)
	{
		//death = FindObjectOfType<DeathScript>();
		//death.Death();

		//target = FindObjectOfType<Target>();
		Instantiate(explosion, transform.position, transform.rotation);
		Destroy(other.gameObject);
		Destroy(gameObject);
		SceneManager.LoadScene(4);
		//target.damage += 1;
	}




}
