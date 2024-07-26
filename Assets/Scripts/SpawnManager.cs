using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] fruitPrefabs; // Array to hold the fruit prefabs
    public Transform spawnPoint; // The point where the fruits will be spawned

    void Start()
    {
        if (fruitPrefabs.Length == 5)
        {
            StartCoroutine(SpawnFruits());
        }
        else
        {
            Debug.LogError("Please assign exactly 4 fruit prefabs.");
        }
    }

    IEnumerator SpawnFruits()
    {
        List<int> spawnOrder = new List<int> { 0, 1, 2, 3, 4 };
        Shuffle(spawnOrder);

        foreach (int index in spawnOrder)
        {
            Instantiate(fruitPrefabs[index], spawnPoint.position, spawnPoint.rotation);
            yield return new WaitForSeconds(1f); // Wait for 1 second between spawns
        }
    }

    void Shuffle(List<int> list)
    {
        for (int i = 0; i < list.Count; i++)
        {
            int temp = list[i];
            int randomIndex = Random.Range(i, list.Count);
            list[i] = list[randomIndex];
            list[randomIndex] = temp;
        }
    }
}
