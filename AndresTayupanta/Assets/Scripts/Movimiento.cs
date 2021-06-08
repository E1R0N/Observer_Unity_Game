using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour {
	//private CharacterController controler;
	private Rigidbody rigid;
	public float speed=3,jumpsforce=6;
	private float distanceToGround;
	Vector3 velocity;
	// Use this for initialization
	void Start () {
		//controler = GetComponent<CharacterController> ();
		rigid = GetComponent<Rigidbody> ();
		distanceToGround = GetComponent<Collider> ().bounds.extents.y; //altura del collider hasta la mitad
	}

	
	// Update is called once per frame
	void UpdateMovement () {
		//controler.Move (transform.forward / 60); //automatico hacia el frente
		float hor=Input.GetAxisRaw("Horizontal");
		float ver=Input.GetAxisRaw("Vertical");

		if (Input.GetAxisRaw ("Fire3") != 0) {
			speed = 6;
			jumpsforce = 8;
		} else {
			speed = 3;
			jumpsforce = 6;
		}
		if (hor != 0 || ver != 0) {
			//Vector3 motion = (transform.forward * ver + transform.right * hor).normalized * speed;
			velocity=(transform.forward * ver + transform.right * hor).normalized * speed;
			//controler.Move (motion*Time.deltaTime);
			//rigid.velocity = motion;
		} else {
			//rigid.velocity = Vector3.zero;
			velocity=Vector3.zero;
		}
		velocity.y = rigid.velocity.y;
		rigid.velocity = velocity;
	}
	public void UpdateJump(){
		if(Input.GetButtonDown("Jump")&&IsGrounded()){
			rigid.AddForce(Vector3.up*jumpsforce,ForceMode.Impulse);
		}
	
	}
	public void Update(){
		UpdateMovement ();
		UpdateJump ();
	}
	private bool IsGrounded(){
		return Physics.BoxCast (transform.position, new Vector3 (0.4f, 0f, 0.4f), Vector3.down, Quaternion.identity, distanceToGround + 0.1f);//vector3 down direccion hacia abajo, Quaternion.identity no rotado
	
	}

	
}
