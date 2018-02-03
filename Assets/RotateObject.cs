using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour {

    [SerializeField] float speed = 5f;
    [SerializeField] float xx = 0f;
    [SerializeField] float yy = 0f;
    [SerializeField] float zz = 0f;

	// Update is called once per frame
	void Update () {
        transform.Rotate(new Vector3(xx, yy, zz) * speed * Time.deltaTime, Space.Self);
	}
}
