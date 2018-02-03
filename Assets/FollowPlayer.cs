using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour {

    [SerializeField] GameObject player;
    [SerializeField] float yOffset = 20f;

    Vector3 offsetFromBall;

	// Use this for initialization
	void Start () {
		
    }
	
	// Update is called once per frame
	void Update () {
        offsetFromBall = new Vector3(player.transform.position.x, yOffset, player.transform.position.z);
        transform.position = offsetFromBall; 
	}
}
