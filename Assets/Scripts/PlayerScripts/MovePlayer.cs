using UnityEngine;
using System.Collections;

public class MovePlayer : MonoBehaviour {

	public int _speed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {



	

		if (Input.GetKey (KeyCode.Q))
			transform.Translate (Vector3.left * Time.deltaTime * _speed);
		if (Input.GetKey (KeyCode.D))
			transform.Translate (-Vector3.left * Time.deltaTime * _speed);
		if (Input.GetKey (KeyCode.Z))
			transform.Translate (Vector3.forward * Time.deltaTime * _speed);
		if (Input.GetKey (KeyCode.S))
			transform.Translate (-Vector3.forward * Time.deltaTime * _speed);
			


	}
}
