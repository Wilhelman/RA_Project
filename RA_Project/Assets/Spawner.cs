using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject turret_target = null;

    public float spawn_timer = 5.0f;
 

    private float timer = 0.0f;


    public Zombie[] zombies;
    private int count = 0;

    // Use this for initialization
    void Start()
    {
        foreach (Zombie z in zombies)
            z.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (count < zombies.Length)
        {
            zombies[count].gameObject.SetActive(true);
            zombies[count].gameObject.transform.position = zombies[count].original_pos;
            count++;
        }

        foreach (Zombie z in zombies)
        {
            if (z.gameObject.active == true)
                z.transform.position += z.speed * z.dir;

            if (Mathf.Abs((z.transform.position - turret_target.transform.position).magnitude) <= 3.0f)
            {
                z.transform.position = this.transform.position;
                z.gameObject.SetActive(false);
            } 
        }

        if (AreAllDead())
            count = 0;

    }

    private bool AreAllDead()
    {
        return zombies[0].gameObject.active == false && zombies[1].gameObject.active == false && zombies[2].gameObject.active == false 
               && zombies[3].gameObject.active == false && zombies[4].gameObject.active == false;
    }

    private Vector3 GetRandomPos(Vector3 current_pos, float random_range)
    {
        float x_pos = Random.Range(-random_range, random_range);
        float z_pos = Random.Range(-random_range, random_range);

        return new Vector3(current_pos.x + x_pos, current_pos.y, current_pos.z + z_pos);
    }
}