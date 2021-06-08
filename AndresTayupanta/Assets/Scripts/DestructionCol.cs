using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestructionCol : MonoBehaviour {
	void OnCollisionEnter(Collision col){
		if (col.gameObject.tag == "enemy") {
				//Destroy (col.gameObject);
			}
		
		}

	
}
