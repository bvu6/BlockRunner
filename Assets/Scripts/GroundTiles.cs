using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundTiles : MonoBehaviour
{
    [SerializeField] private GameObject obstacle;
    private Vector3 quadrant1;
    private Vector3 quadrant2;
    private Vector3 quadrant3;
    private Vector3[] quadrants = new Vector3[4];
    // Start is called before the first frame update
    void Start()
    {
        SpawnObstacle();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnObstacle()
    {   //random location for obstacles
        quadrants[0] = new Vector3(Random.Range(-10, 20), 0.6f, Random.Range(-386, -24));
        quadrants[1] = new Vector3(Random.Range(-10, 20), 0.6f, Random.Range(-386, -24));
        quadrants[2] = new Vector3(Random.Range(-10, 20), 0.6f, Random.Range(-386, -24));
        quadrants[3] = new Vector3(Random.Range(-10, 20), 0.6f, Random.Range(-386, -24));
        Instantiate(obstacle, quadrants[0], obstacle.transform.rotation);
        Instantiate(obstacle, quadrants[1], obstacle.transform.rotation);
        Instantiate(obstacle, quadrants[2], obstacle.transform.rotation);
        Instantiate(obstacle, quadrants[3], obstacle.transform.rotation);
    }
}
