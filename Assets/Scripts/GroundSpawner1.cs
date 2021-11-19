using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSpawner1 : MonoBehaviour
{
    public GameObject[] allTiles;
    public GameObject nextTile;
    int indexInTiles;
    Vector3 nextSpawnPoint;

    public void SpawnTile(bool spawnItems)
    {
        //tile select
        indexInTiles = Random.Range(0, allTiles.Length);
        nextTile = allTiles[indexInTiles];

        //spawn
        GameObject temp = Instantiate(nextTile, nextSpawnPoint, Quaternion.identity);
        nextSpawnPoint = temp.transform.GetChild(1).transform.position;

        if (spawnItems)
        {
            temp.GetComponent<GroundTile>().SpawnObsticle();
            temp.GetComponent<GroundTile>().SpawnCoins();
        }
    }

    private void Start()
    {
        for (int i = 0; i < 15; i++)
        {
            if (i < 3)
            {
                SpawnTile(false);
            }
            else
            {
                SpawnTile(true);
            }

        }
    }

}
