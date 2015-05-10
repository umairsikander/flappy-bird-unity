﻿using UnityEngine;
using System.Collections;

public class Cameratrackplayer : MonoBehaviour {

	Transform player;
	float offsetX=0;

	// Use this for initialization
	void Start () {

		GameObject player_go = GameObject.FindGameObjectWithTag("Player");
		if(player_go == null)
		{
			Debug.LogError("Could'nt find the object with tag 'Player'!");
			return;
		}
		player = player_go.transform;
	}
	
	// Update is called once per frame
	void Update () {
		if(player != null)
		{
			Vector3 pos = transform.position;
			pos.x = player.position.x + offsetX;
			transform.position= pos;
		}
	}
}
