using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundTile : MonoBehaviour
{

    GroundSpawner1 groundspawner;


  private void Start()
   {
        groundspawner = GameObject.FindObjectOfType<GroundSpawner1>();
   }

    private void OnTriggerExit(Collider other)
    {
        groundspawner.SpawnTile();
            Destroy(gameObject, 2);
    }
   
    void Update()
    {
        
    }

    public GameObject obsticlePrefab;

    void SpawnObsticle()
    {
        int obsticleSpawnIndex = Random.Range(2, 5);
        Transform spawnPoint = transform.GetChild(obsticleSpawnIndex).transform;
        Instantiate(obsticlePrefab, spawnPoint.position, Quaternion.identity, transform);
    }



}
