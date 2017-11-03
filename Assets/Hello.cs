using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hello : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Debug.Log("Hello");
        Debug.Log("9:18분");
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(0f,30f* Time.deltaTime,0f);
	}
}
