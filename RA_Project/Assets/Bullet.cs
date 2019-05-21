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
        transform.Translate(-Vector3.forward * velocity);
    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Goal" || collision.gameObject.tag == "Goalkeeper")
        {
            Destroy(this.gameObject);
        }
    }
}