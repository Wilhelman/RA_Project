using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

    public float velocity = 1.0f;
    public GameObject goal;
    public GameObject goalkeeper;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.forward * velocity);
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject == goal)
        {
            // 1 POINT TO GRIFFINDOR
            Destroy(this);
        }else if( collision.gameObject == goalkeeper)
        {
            // 1 POINT TO SLICERING
            Destroy(this);
        }


    }
}
