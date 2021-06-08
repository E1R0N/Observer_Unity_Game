using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour {
	public GameObject bullet;//la bala :D
	public Transform spawnbullet;//lugar donde la bala inicia su recorrido
	public float bulletforce = 1500;//fuerza del proyectil
	public float shotrate=0.5f; //tiempo entre diparo
	private float shotratetime = 0;
	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Fire1") ){
			if (Time.time > shotratetime) {
				GameObject newbullet;
				newbullet = Instantiate (bullet, spawnbullet.position, spawnbullet.rotation);//instancia la bala, con posicion y rotacion
				newbullet.GetComponent<Rigidbody> ().AddForce (spawnbullet.forward * bulletforce);//da la fuerza a la bala
				newbullet.tag = "balas";
				shotratetime = Time.time +shotrate ;//solo dispara pasados shotratetime
				Destroy(newbullet,2);
			}
		}
	}

}
