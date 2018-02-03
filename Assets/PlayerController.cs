using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerController : MonoBehaviour {

    private Rigidbody rb;

    [SerializeField] float speed = 250f;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(5f, 0f, 0f);
	}
	
	// Update is called once per frame
	void Update ()
    {
        MovePlayer();
    }

    private void MovePlayer()
    {
        float hInput = CrossPlatformInputManager.GetAxis("Horizontal");
        float vInput = CrossPlatformInputManager.GetAxis("Vertical");

        float hOffset = hInput * speed * Time.deltaTime;
        float vOffset = vInput * speed * Time.deltaTime;

        rb.AddForce(new Vector3(hOffset, 0f, vOffset));
    }
}
