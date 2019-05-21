using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ui : MonoBehaviour {

    public Text thing;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Alpha1))
            thing.text = "one pressed";

        if (Input.GetKeyDown(KeyCode.Alpha2))
            thing.text = "two pressed";
    }
}
