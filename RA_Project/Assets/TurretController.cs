using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		if (Input.GetKey("left"))
		{
			transform.Rotate(0, -5, 0, Space.Self);
		}

		if (Input.GetKey("right"))
		{
			transform.Rotate(0, 5, 0, Space.Self);
		}
        
    }
}
