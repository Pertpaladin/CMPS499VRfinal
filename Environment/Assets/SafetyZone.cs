using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SafetyZone : MonoBehaviour
{
    Transform mask;
    Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        mask = GameObject.Find("Camera").transform;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = 
    }
}
