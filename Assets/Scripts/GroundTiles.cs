using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundTiles : MonoBehaviour
{
    [SerializeField] private GameObject obstacle;
    [SerializeField] private GameObject coin; 
    private Vector3 quadrant1;
    private Vector3 quadrant2;
    private Vector3 quadrant3;
    private Vector3[] quadrants = new Vector3[4];
    // Start is called before the first frame update
    void Start()
    {
        CreateAud();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnObstacle()
    {   //random location for obstacles
        quadrants[0] = new Vector3(Random.Range(33, 70), 0.6f, Random.Range(-790, 330));
        quadrants[1] = new Vector3(Random.Range(33, 70), 0.6f, Random.Range(0, 330));
        quadrants[2] = new Vector3(Random.Range(33, 70), 0.6f, Random.Range(-790, -500));
        quadrants[3] = new Vector3(Random.Range(33, 70), 0.6f, Random.Range(-500, 0));
    }

    private void SpawnCoin()
    {
        quadrants[0] = new Vector3(Random.Range(36, 70), 1.7f, Random.Range(-790, 330));
        quadrants[1] = new Vector3(Random.Range(36, 70), 1.7f, Random.Range(0, 330));
        quadrants[2] = new Vector3(Random.Range(36, 70), 1.7f, Random.Range(-790, -500));
        quadrants[3] = new Vector3(Random.Range(36, 70), 1.7f, Random.Range(-500, 0));
    }

    private void CreateAud()
    {
        SpawnObstacle();
        SpawnCoin();

        for (int i = 0; i < 20; i++)
        {
            SpawnObstacle();
            Instantiate(obstacle, quadrants[i%3], obstacle.transform.rotation); 
        }
        
        for (int i = 0; i < 30; i++)
        {
            SpawnCoin();
            Instantiate(coin, quadrants[i%3], coin.transform.rotation);
        }

    }
}
