using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

    public float velocity = 1.0f;
    public GameObject goal;
    public GameObject goalkeeper;
    public Manager manager;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.forward * velocity);
    }

    void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.tag == "Goal")
        {
            // 1 POINT TO GRIFFINDOR
            manager.UpdateGoals();
            Destroy(this.gameObject);
        }else if(collision.gameObject.tag == "Goalkeeper")
        {
            // 1 POINT TO SLICERING
            manager.UpdateStopped();
            Destroy(this.gameObject);

        }

        Debug.Log("Hello motherfucker!");
    }
}
