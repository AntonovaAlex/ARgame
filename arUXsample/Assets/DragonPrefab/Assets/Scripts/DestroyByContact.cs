using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByContact : MonoBehaviour
{
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
		//target.damage += 1;
	}
}
