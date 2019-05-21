using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour
{
    public Vector3 original_pos = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        original_pos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
