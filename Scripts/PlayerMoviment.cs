using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoviment : MonoBehaviour
{
    public float jumpInput , speed , jumpForce;
    
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        //FAZ O PLAYER PULAR
        jumpInput = Input.GetAxis("Jump");
        transform.Translate(Vector3.up * Time.deltaTime * jumpForce * jumpInput);

        //DESTRÓI
      
        
    }
}
