using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Turret5000XL : MonoBehaviour {

    public GameObject bullet = null;

    public float shoot_timer = 3.0f;

    private float timer = 0.0f;

    int shooter_points = 0;
    int keeper_points = 0;


    // Use this for initialization
    void Start() { }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > shoot_timer)
        {
            timer = 0.0f;
            Instantiate(bullet, transform.position, Quaternion.identity, this.transform);
        }
    }

}
