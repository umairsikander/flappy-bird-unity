using UnityEngine;
using System.Collections;

public class Bglooper : MonoBehaviour {
	int numBGPanels = 6;

	void OnTriggerEnter2D(Collider2D collider)
	{
		Debug.Log("Triggered :" + collider.name);
		float widthofBGObject = ((BoxCollider2D)collider).size.x;
		Vector3 pos = collider.transform.position;
		pos.x += widthofBGObject * numBGPanels - widthofBGObject/2f;
		collider.transform.position = pos;
	}


}
