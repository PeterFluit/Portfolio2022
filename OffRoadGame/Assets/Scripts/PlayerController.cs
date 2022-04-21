using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour

{
    public float speed;
    public float turnSpeed;
    public float horizontalInput;
    
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    { 
        //Lets player move left and right
        horizontalInput = Input.GetAxis("Horizontal");

         //move car forward at a constant rate
        transform.Translate(Vector3.back * speed*Time.deltaTime);
        transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);
    }
}
