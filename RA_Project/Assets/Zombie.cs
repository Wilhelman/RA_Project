using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour
{
    public GameObject turret_target = null;
    public Vector3 original_pos = Vector3.zero;
    public float speed = 100.0f;

    // Start is called before the first frame update
    void Start()
    {
        original_pos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, turret_target.transform.position, speed);
    }
}
