using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour {

	 CastleHealth castle;

	public AudioSource damageSound;
	//private int health = 1;
	//private  Target target;

	//void OnTriggerEnter(Collider other)
	//{
	//	target = FindObjectOfType<Target>();
	//	//Instantiate(explosion, transform.position, transform.rotation);
	//	//Destroy(other.gameObject);
	//	//Destroy(gameObject);
	//	target.damage += 1;
	//}
	public GameObject explosion;

	//private Target target;



	void OnTriggerEnter(Collider other)
	{
		damageSound.Play();

		Debug.Log("Damage!");
		castle = FindObjectOfType<CastleHealth>();
		castle.CastleDam();
		//target = FindObjectOfType<Target>();
		Instantiate(explosion, transform.position, transform.rotation);
		Destroy(other.gameObject);
		Destroy(gameObject);
		//target.damage += 1;
		

	}

}
