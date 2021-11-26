using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundTile : MonoBehaviour
{

    GroundSpawner1 groundspawner;
    [SerializeField] GameObject coinPrefab;
    [SerializeField] GameObject obsticlePrefab;

    private void Start()
    {
        groundspawner = GameObject.FindObjectOfType<GroundSpawner1>();

    }

    private void OnTriggerExit(Collider other)
    {
        groundspawner.SpawnTile(true);
        Destroy(gameObject, 2);
    }


    public void SpawnObsticle()
    {
        int obsticleSpawnIndex = Random.Range(2, 5);
        Transform spawnPoint = transform.GetChild(obsticleSpawnIndex).transform;
        Instantiate(obsticlePrefab, spawnPoint.position, Quaternion.identity, transform);
    }



    public void SpawnCoins()
    {
        int coinsToSpawn = 2;
        for (int i = 0; i < coinsToSpawn; i++)
        {
            GameObject temp = Instantiate(coinPrefab, transform);
            temp.transform.position = GetRandomPointInCollider(GetComponent<Collider>());
        }
    }
    Vector3 GetRandomPointInCollider(Collider collider)
    {
        Vector3 point = new Vector3(
       Random.Range(collider.bounds.min.x, collider.bounds.max.x),
       Random.Range(collider.bounds.min.y, collider.bounds.max.y),
       Random.Range(collider.bounds.min.z, collider.bounds.max.z)
       );


        if (point != collider.ClosestPoint(point))
        {
            point = GetRandomPointInCollider(collider);

        }

        point.y = 1;
        return point;


    }
}
