using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Recoger : MonoBehaviour
{
    private Rigidbody rigid;
    void OnTriggerEnter(Collider other) {
        rigid = GetComponent<Rigidbody> ();
        if (other.gameObject.CompareTag("pistola")){
             other.gameObject.transform.parent = GameObject.Find("Contenedor").transform;
			 other.gameObject.transform.position=rigid.position;
        }
        
     }

}
