using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    public int vidas=5;
    public GameObject enemigo;
    public TextMesh medidor=new TextMesh();
	// Use this for initialization
	void OnCollisionEnter(Collision col){
        
        if (col.gameObject.tag == "balas") {
			vidas=vidas-1;
            medidor.text=vidas.ToString();
            if (vidas<=0){
                medidor.text="Desaparecio el objeto observado";
            }
            if(vidas==0){
                Destroy(enemigo,1);
            }
		print(vidas);
		}

	}

}
