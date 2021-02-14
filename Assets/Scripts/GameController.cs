using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject[] RoadPrefabs;
    public float lengthRoad = 30;
    public GameObject startRoad;
    public Transform playerTransform;
    public int visibilityRange = 2;

    private List<GameObject> currentRoads = new List<GameObject>();
    private float nextPositionRoad = 34.0f;

    void Start()
    {
        currentRoads.Add(startRoad);
        for (int i = 0; i < visibilityRange; i++)
        {
            currentRoads.Add(Instantiate(RoadPrefabs[Random.Range(0, RoadPrefabs.Length)], new Vector3(0, 0, lengthRoad * (i + 1) + currentRoads[0].transform.position.z), Quaternion.Euler(0, 0, 0)));
        }
    }

    void Update()
    {
        if (playerTransform.position.z >= nextPositionRoad)
        {
            //Debug.Log("New road!");
            currentRoads.Add(Instantiate(RoadPrefabs[Random.Range(0, RoadPrefabs.Length)], new Vector3(0, 0, lengthRoad * (visibilityRange + 1) + currentRoads[0].transform.position.z), Quaternion.Euler(0, 0, 0)));

            Destroy(currentRoads[0]);
            currentRoads.RemoveAt(0);

            nextPositionRoad += lengthRoad;
        }
    }
}
