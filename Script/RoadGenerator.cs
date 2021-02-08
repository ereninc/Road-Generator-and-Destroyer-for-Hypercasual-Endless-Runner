using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.UI;

public class RoadGenerator : MonoBehaviour
{
    [SerializeField] private GameObject[] RoadPrefabs;
    [SerializeField] private GameObject player;
    [SerializeField] private float nextStep = 0;
    [SerializeField] private Transform startPosition;
    

    void Start()
    {
        StartCoroutine(GenerateRoad());
    }

    IEnumerator GenerateRoad()
    {
        while (player.transform.position.y >= -0.140f)
        {
            GameObject randomRoadPrefab = RoadPrefabs[Random.Range(0, RoadPrefabs.Length)];
            Instantiate(randomRoadPrefab, new Vector3(startPosition.position.x, startPosition.position.y, startPosition.position.z + nextStep), randomRoadPrefab.transform.rotation);
            nextStep += 65;
            yield return new WaitForSeconds(2);
        }
    }
}