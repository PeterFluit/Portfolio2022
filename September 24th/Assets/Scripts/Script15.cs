using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script15 : MonoBehaviour
{
     void Update ()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            Destroy(gameObject);
        }
    }
}
