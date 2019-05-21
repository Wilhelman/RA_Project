using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject zombie_prefab = null;

    public float spawn_timer = 3.0f;

    private float timer = 0.0f;

	// Use this for initialization
	void Start () {}
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;
        Debug.Log(timer);
        if (timer > spawn_timer)
        {
            timer = 0.0f;
            float x_pos = Random.Range(-20.0f, 20.0f);
            float z_pos = Random.Range(-20.0f, 20.0f);
            Vector3 random_pos = new Vector3(transform.position.x + x_pos, transform.position.y, transform.position.z + z_pos);
            Instantiate(zombie_prefab, random_pos, Quaternion.identity, this.transform);
        }
	}
}