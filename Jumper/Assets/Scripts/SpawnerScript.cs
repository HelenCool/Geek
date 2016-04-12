using UnityEngine;
using System.Collections;

public class SpawnerScript : MonoBehaviour {

    public GameObject[] itemsToSpawn;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void Spawn()
    {
        Instantiate(
            itemsToSpawn[Random.Range(0, itemsToSpawn.Length)], // то, что мы интанциируем
            new Vector3(Random.Range(0, 4), this.transform.position.y), Quaternion.identity);
    }

}
