using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdSpawner : MonoBehaviour
{
    public Transform[] spawnPositions;
    public GameObject[] birds;
    public bool keepSpawning = true;
    public Transform flyingBirds; 

    float PROBABILITY = 0.5f;
    public float spawnDelay = 0.5f;

    // Start is called before the first frame update
    void Start()
    {

        StartCoroutine("Spawn");
    }


    IEnumerator Spawn()
    {
        while (keepSpawning)
        {
            float shouldSpawn = Random.Range(0f, 1f);
            if (shouldSpawn >= PROBABILITY || flyingBirds.childCount == 0)
            {
                GameObject originalObject = GetRandomBird();
                Transform startTransform = GetRandomStartTransform();

                GameObject birdObject = Instantiate(originalObject, flyingBirds);
                birdObject.transform.position = startTransform.position;
            }
            yield return new WaitForSeconds(spawnDelay);
        }
    }

    GameObject GetRandomBird()
    {
        int index = Random.Range(0, birds.Length);
        return birds[index];
    }

    Transform GetRandomStartTransform()
    {
        int index = Random.Range(0, spawnPositions.Length);
        return spawnPositions[index];
    }

}
