using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour
{
    public GameObject turret_target = null;
    public Vector3 original_pos = Vector3.zero;
    public Vector3 dir = Vector3.zero;
    public float speed = 100.0f;

    // Start is called before the first frame update
    void Start()
    {
        original_pos = transform.position;
        dir = turret_target.transform.position - transform.position;
        dir.Normalize();
        Debug.Log(dir.magnitude);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
