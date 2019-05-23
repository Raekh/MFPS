using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannotFall : MonoBehaviour {
	
	void OnTriggerEnter(Collider other){
		Debug.Log ("Collision with " + other.gameObject.name);
		this.gameObject.GetComponent<Rigidbody> ().velocity = Vector3.zero;
		this.gameObject.GetComponent<Rigidbody> ().isKinematic = true;
		this.gameObject.transform.rotation = Quaternion.identity;
		this.gameObject.transform.position = new Vector3(0f, 0f, 0f);
		this.gameObject.GetComponent<Rigidbody> ().isKinematic = false;
	}
}
