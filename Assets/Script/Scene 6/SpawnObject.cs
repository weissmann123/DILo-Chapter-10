using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObject : MonoBehaviour
{
    public GameObject spawnee;
    public bool stopSpawning = false;
    public float spawnDelay;
    public int current;
    public int max;
    // Start is called before the first frame update
    void Start()
    {
        max = Random.Range(5, 10);
        current = 0;
    }
    void Update()
    {
        if(current < max && stopSpawning == false)
        {
            Spawn();
        }
    }
    public void Spawn()
    {
        current++;
        Vector3 position = new Vector3(Random.Range(-4.0F, 4.0F), 1, Random.Range(-4.0F, 4.0F));
        //Instantiate(spawnee, transform.position, transform.rotation);
        Instantiate(spawnee, position, Quaternion.identity);
    }
}
