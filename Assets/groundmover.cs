﻿using UnityEngine;
using System.Collections;

public class groundmover : MonoBehaviour {

	float speed = 0.9f;

	// Update is called once per frame
	void FixedUpdate ()
	{
		Vector3 pos= transform.position;
		pos.x += speed * Time.deltaTime;
		transform.position = pos;
	}
}
