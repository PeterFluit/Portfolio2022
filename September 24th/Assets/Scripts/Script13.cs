using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script13 : MonoBehaviour
{
       public Transform target;
    
    void Update ()
    {
        transform.LookAt(target);
    }
}
