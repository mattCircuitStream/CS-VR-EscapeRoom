using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeySpawner : MonoBehaviour
{
    [SerializeField] private GameObject prefabToSpawn;
    [SerializeField] private Transform spawnLocation;
    private GameObject instance;
    public void SpawnKey()
    {
        Destroy(instance); // only spawn 1 key at a time
        instance = Instantiate(prefabToSpawn, spawnLocation);
        instance.transform.parent = null;
    }
}
