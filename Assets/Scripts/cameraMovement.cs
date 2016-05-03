using UnityEngine;
using System.Collections;

public class cameraMovement : MonoBehaviour {
	[SerializeField]
	public GameObject player;
	public Vector3 offest;
	// Use this for initialization
	void Start () {
		offest = transform.position - player.transform.position;
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = player.transform.position + offest;
	
	}
}
