using UnityEngine;
using System.Collections;

public class rotationObject : MonoBehaviour {

	Vector3 oldPos = Vector3.zero;
	// Use this for initialization
	void Start () 
	{
		this.transform.rotation = Quaternion.Euler (new Vector3(Random.Range(-45, 45), Random.Range(-45, 45), Random.Range(-45, 45)));
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetMouseButton(0) && Input.GetKey(KeyCode.LeftControl))
			this.transform.Rotate(new Vector3(0.0f, 0.0f, Input.mousePosition.x - oldPos.x));
		else if (Input.GetMouseButton(0) && Input.GetKey(KeyCode.LeftShift))
			this.transform.Rotate(new Vector3(0.0f, Input.mousePosition.x - oldPos.x, 0.0f));
		else if (Input.GetMouseButton(0))
			this.transform.Rotate (new Vector3(Input.mousePosition.x - oldPos.x, 0.0f, 0.0f));
		oldPos = Input.mousePosition;
	}
}
