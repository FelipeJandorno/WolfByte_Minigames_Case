using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject   obstaclesPrefab; //OBJETO A SER SPAWNADO
    public float        rateSpawn;       //INTERVALO ENTRE OS SPAWNS
    public float        currentTime;
    private int         position;
    private float       y;

    void Start()
    {
        currentTime = 0;    
    }

    void Update()
    {
        currentTime += Time.deltaTime;
        if(currentTime >= rateSpawn)
        {
            currentTime = 0;
            position = Random.Range(1, 100);
            if(position>50)
            {
                y=-0.5f;
            }
            else
            {
                y= -2f;
            }
            
        GameObject tempPrefab = Instantiate(obstaclesPrefab) as GameObject;
        tempPrefab.transform.position = new Vector3(transform.position.x, y, tempPrefab.transform.position.z);

        }
    }
}
