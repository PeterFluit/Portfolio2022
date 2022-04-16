using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script16 : MonoBehaviour
{
    public GameObject other;
    
    
    void Update ()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            Destroy(other);
        }
    }
}
