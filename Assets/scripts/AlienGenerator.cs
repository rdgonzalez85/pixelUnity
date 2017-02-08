using UnityEngine;
using System.Collections;

public class AlienGenerator : MonoBehaviour {

	public GameObject[] aliens;
	public float spawnRate = 10.0f;

	// Use this for initialization
	void Start () {
		StartCoroutine (SpawnAlien ());
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	IEnumerator SpawnAlien() {
		yield return new WaitForSeconds (2.0f);
		while (true) {
			//Random r = new Random();
			int rInt = Random.Range(0,aliens.Length);
			Vector3 position = new Vector3 (0.0f, transform.position.y, transform.position.z);

			Instantiate (aliens[rInt], position, Quaternion.identity);
			yield return new WaitForSeconds(spawnRate);
		}
	}
}
