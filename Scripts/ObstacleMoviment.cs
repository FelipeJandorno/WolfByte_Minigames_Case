using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMoviment : MonoBehaviour
{

    public float obstacleSpeed , x;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    
    //MOVIMENTO DO OBSTÁCULO    
        transform.Translate(Vector3.left * obstacleSpeed * Time.deltaTime);

    //DESTROI O OBSTÁCULO
        x = transform.position.x; 
        if(x<= -15){
            Destroy(transform.gameObject);
        }
    }
}
