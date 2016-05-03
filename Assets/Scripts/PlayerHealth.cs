using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour {


		[SerializeField]
		private HealthBar bar;

		[SerializeField]
		private float maxVal;

		public float alivetime;
		float currentVal;

		playerController controlMovement;
		
		//HUD Variables
		




		void Start(){
		currentVal = maxVal;

		controlMovement = GetComponent<playerController>();

		}

		public float CurrentVal
		{
			get
			{
				return currentVal;
			}
			set
			{
				this.currentVal = value;
				bar.Value = currentVal;
			}
		}

		public float MaxVal
		{
			get
			{
				return maxVal;
			}
			set
			{
				this.maxVal = value;
				bar.MaxValue = maxVal;
			}
		}
		
		void Update(){
		Initialize ();


	}
		
	public void addDamage(float damage){
		if (damage <= 0) 
			return;
			currentVal -= damage;



		if(currentVal<=0){
			currentVal = 0;
			makeDead ();
		}


	}

	public void makeDead(){
		Destroy (gameObject,alivetime);
	}
		
		public void Initialize()
		{
			this.MaxVal = maxVal;
			this.CurrentVal = currentVal;
		}
	}


