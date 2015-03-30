using UnityEngine;
using System.Collections;

public class RotateOnTrigger: MonoBehaviour {

	public GameObject _object = null;
	public GameObject _level;

	public bool _toTrigger;
	

	void Start()
	{

		_level = GameObject.Find("Level");

	}

	void Update()
	{

		if (_toTrigger) {
		
			if(Input.GetKeyDown(KeyCode.Space))
			{

				_object.transform.RotateAround(_object.transform.FindChild("Pivot").gameObject.transform.position,Vector3.left,-90f);
				transform.RotateAround(_object.transform.FindChild("Pivot").gameObject.transform.position,Vector3.left,-90f);
				_level.transform.Rotate(new Vector3(-90,0,0));

			}
		}

	}

	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "ToTrigger") {
		
			_object = other.gameObject;
			_toTrigger = true;
			GetComponent<Renderer>().material.color = Color.black;
		}

		if (other.tag == "Trigger") {
			
			_object = other.gameObject;
			_object.transform.RotateAround(_object.transform.FindChild("Pivot").gameObject.transform.position,Vector3.left,-90f);
			_object.GetComponent<Collider>().enabled = false;
		}
	}

	void OnTriggerExit(Collider other)
	{
		if (other.tag == "ToTrigger") {
		
			_object = null;
			_toTrigger = false;
			GetComponent<Renderer>().material.color = Color.white;
		}
	}


}
