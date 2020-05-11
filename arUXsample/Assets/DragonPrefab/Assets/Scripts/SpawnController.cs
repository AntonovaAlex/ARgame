using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnController : MonoBehaviour {

	public GameObject cannonBall;
	//public Vector3 spawnValues1;
	//public Vector3 spawnValues2;
	//public Vector3 spawnValues3;

	//public Vector3 spawnRot1;

	public int ballCount;
	public float spawnWait;
	public float startWait;
	public float waveWait;
	int a;


	public GameObject cannon1; //самая высокая
	public GameObject cannon2;
	public GameObject cannon3;

	void Start()
	{
		StartCoroutine (SpawnWaves ());
	}

	IEnumerator SpawnWaves ()
	{
		yield return new WaitForSeconds(startWait);
		while (true) { 
		for (int i = 0; i < ballCount; i++)
		{
			a = Random.Range(1, 4);
			Debug.Log(a);
			if (a == 1)
			{
					////Vector3 spawnPosition = new Vector3(spawnValues1.x, spawnValues1.y, spawnValues1.z);
					//Vector3 spawnPosition = new Vector3(cannon1.transform.position.x + 0.13f, cannon1.transform.position.y + 0.042f, cannon1.transform.position.z + 0.002f);
					////Quaternion spawnRotation = Quaternion.identity;
					//Quaternion spawnRotation = Quaternion.Euler(0, 90, 0);

					//	Instantiate(cannonBall, spawnPosition, spawnRotation);

					//yield return new WaitForSeconds(spawnWait);

					GameObject bullet = Instantiate(Resources.Load("eBullet", typeof(GameObject))) as GameObject;
					Rigidbody rb = bullet.GetComponent<Rigidbody>();


					Vector3 bullet3Rotation = new Vector3(cannon1.transform.rotation.x, cannon1.transform.rotation.y, cannon1.transform.rotation.z);

					bullet.transform.rotation = Quaternion.Euler(bullet3Rotation);
					bullet.transform.position = new Vector3(cannon1.transform.position.x + 0.13f, cannon1.transform.position.y + 0.051f, cannon1.transform.position.z + 0.002f);



					rb.AddForce(cannon1.transform.forward * 30f);
					yield return new WaitForSeconds(spawnWait);
					Destroy(bullet, 1.5f);


				}
				if (a == 2)
			{
					////Vector3 spawnPosition = new Vector3(spawnValues2.x, spawnValues2.y, spawnValues2.z);
					//Vector3 spawnPosition = new Vector3(cannon2.transform.position.x + 0.13f, cannon2.transform.position.y + 0.043f, cannon2.transform.position.z + 0.002f);

					////Quaternion spawnRotation = Quaternion.identity;
					//Quaternion spawnRotation = Quaternion.Euler(0, 90, 0);


					//	Instantiate(cannonBall, spawnPosition, spawnRotation);
					//yield return new WaitForSeconds(spawnWait);





					GameObject bullet = Instantiate(Resources.Load("eBullet", typeof(GameObject))) as GameObject;
					Rigidbody rb = bullet.GetComponent<Rigidbody>();

					
					Vector3 bullet3Rotation = new Vector3(cannon2.transform.rotation.x, cannon2.transform.rotation.y, cannon2.transform.rotation.z);

					bullet.transform.rotation = Quaternion.Euler(bullet3Rotation);
					bullet.transform.position = new Vector3(cannon2.transform.position.x + 0.13f, cannon2.transform.position.y + 0.051f, cannon2.transform.position.z + 0.002f);
					


					rb.AddForce(cannon2.transform.forward * 30f);
					yield return new WaitForSeconds(spawnWait);


					Destroy(bullet, 1.5f);



				}
			if (a == 3)
			{
					//Vector3 spawnPosition = new Vector3(spawnValues3.x, spawnValues3.y, spawnValues3.z);

					//Vector3 spawnPosition = new Vector3(cannon3.transform.position.x + 0.13f, cannon3.transform.position.y + 0.163f, cannon3.transform.position.z + 0.002f);
					//Rigidbody ballRb = cannonBall.GetComponent<Rigidbody>();

					GameObject bullet = Instantiate(Resources.Load("eBullet", typeof(GameObject))) as GameObject;
					Rigidbody rb = bullet.GetComponent<Rigidbody>();

					//Vector3 spawnPosition = new Vector3(cannon3.transform.position.x + 0.13f, cannon3.transform.position.y + 0.051f, cannon3.transform.position.z + 0.002f);
					Vector3 bullet3Rotation = new Vector3(cannon3.transform.rotation.x, cannon3.transform.rotation.y, cannon3.transform.rotation.z);

					bullet.transform.rotation = Quaternion.Euler(bullet3Rotation);
					bullet.transform.position = new Vector3(cannon3.transform.position.x + 0.13f, cannon3.transform.position.y + 0.051f, cannon3.transform.position.z + 0.002f);
					//Quaternion spawnRotation = Quaternion.identity;
					//Quaternion spawnRotation = Quaternion.Euler(0, 90, 0);
					//Quaternion spawnRotation = Quaternion.Euler(0.0f, -90f, 0.0f);

					//Instantiate(cannonBall, spawnPosition, spawnRotation);

					
					rb.AddForce(cannon3.transform.forward * 30f);
					yield return new WaitForSeconds(spawnWait);

					Destroy(bullet, 1.5f);
				}
		}
			yield return new WaitForSeconds(waveWait);
		}
	}
}
