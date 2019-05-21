using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject zombie_prefab = null;

    public float spawn_timer = 3.0f;

    private float timer = 0.0f;

    public GameObject[] zombies;
    private int count = 0;

    // Use this for initialization
    void Start() {

        foreach (GameObject z in zombies)
            z.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown("space") && count < zombies.Length)
        {
            zombies[count].SetActive(true);
            count++;
        }

        //timer += Time.deltaTime;

            /*if (timer > spawn_timer && count != zombies.Length())
            {
                timer = 0.0f;
                count++;
                float x_pos = Random.Range(-1.0f, 1.0f);
                float z_pos = Random.Range(-1.0f, 1.0f);
                Vector3 random_pos = new Vector3(transform.position.x + x_pos, transform.position.y, transform.position.z + z_pos);

            }*/
    }
}
