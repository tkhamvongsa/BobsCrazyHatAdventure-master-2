using UnityEngine;
using System.Collections;

public class knifeHit : MonoBehaviour {

	public float weaponDamage;

	knifeController myPC;

	// Use this for initialization
	void Awake () {
		myPC = GetComponentInParent<knifeController> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.layer == LayerMask.NameToLayer ("Shootable")) {

			myPC.removeForce ();

			Destroy (gameObject);

			if (other.tag == "Enemy") {
				enemyHealth hurtEnemy = other.gameObject.GetComponent<enemyHealth> ();
				hurtEnemy.addDamage (weaponDamage);
			}
		}

	}

	void OnTriggerStay2D(Collider2D other){
		if (other.gameObject.layer == LayerMask.NameToLayer ("Shootable")) {

			myPC.removeForce ();

			Destroy (gameObject);

			if (other.tag == "Enemy") {
				enemyHealth hurtEnemy = other.gameObject.GetComponent<enemyHealth> ();
				hurtEnemy.addDamage (weaponDamage);
			}
		}
	}
}
