using UnityEngine;
using System.Collections;

public class birdmovment : MonoBehaviour {
	Vector3 velocity= Vector3.zero;
	public Vector3 gravity;
	public Vector3 flapVelocity;
	public float maxSpeed= 5f;
	public float forwardSpeed = 1f;
	
	bool didFlap= false;
	// Use this for initialization
	void Start () {
	
	}
	//Do graphic and input updates
	void Update(){
		if(Input.GetKeyDown(KeyCode.S)|| Input.GetMouseButtonDown(0))
		{
			didFlap=true;
		}
	}
	
	// Do physics engine updates here
	void FixedUpdate () 
	{
		velocity.x = forwardSpeed;
		velocity = velocity + gravity * Time.deltaTime;

		if(didFlap== true)
		{
			didFlap = false;
			velocity = velocity + flapVelocity;
		}
		transform.position+= velocity * Time.deltaTime;
	}
}
