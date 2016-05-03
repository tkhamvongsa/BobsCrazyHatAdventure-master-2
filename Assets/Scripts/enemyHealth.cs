using UnityEngine;
using System.Collections;

public class enemyHealth : MonoBehaviour {

	[SerializeField]
	public float enemyMaxHealth;


	float currentHealth;

	[SerializeField]
	public GameObject healthBar;
	// Use this for initialization



	void Start () {

		currentHealth = enemyMaxHealth;


	}


	// Update is called once per frame
	void Update () {

	}

	public void addDamage(float damage)
	{

		currentHealth -= damage;
		if (currentHealth <= 0)
			makeDead ();
		float calculatedVal = currentHealth / enemyMaxHealth;
		SetHealthBar (calculatedVal);
	}

	public void SetHealthBar(float myHealth)
	{
		healthBar.transform.localScale = new Vector3 (myHealth, healthBar.transform.localScale.y, healthBar.transform.localScale.z);
	}

	void makeDead(){
		Destroy (gameObject);
	}
}