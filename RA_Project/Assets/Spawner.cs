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
        timer += Time.deltaTime;

        if (timer > spawn_timer && count != zombies.Length)
        {
            zombies[count].SetActive(true);
            timer = 0.0f;
            count++;
        }

        // TODO: if all zombies are dead start again

    }

    private Vector3 GetRandomPos(Vector3 current_pos, float random_range)
    {
        float x_pos = Random.Range(-random_range, random_range);
        float z_pos = Random.Range(-random_range, random_range);

        return new Vector3(current_pos.x + x_pos, current_pos.y, current_pos.z + z_pos);
    }
}
