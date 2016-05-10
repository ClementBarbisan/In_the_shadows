using UnityEngine;
using System.Collections;

public class rotationObject : MonoBehaviour {
	int difficulty;
	Vector3 oldPos = Vector3.zero;
	public bool choosen = false;
	// Use this for initialization
	void Awake () 
	{
		difficulty = PlayerPrefs.GetInt ("difficulty");
		if (difficulty == 0)
			this.transform.Rotate(new Vector3(Random.Range(-90, 90), 0.0f, 0.0f));
		else if (difficulty >= 1)
			this.transform.Rotate(new Vector3(Random.Range(-90, 90), Random.Range(-90, 90), 0.0f));
		if (difficulty == 2)
			this.transform.Translate (0.0f, 0.0f, Random.Range(-3, 3), Space.World);
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (choosen) {
			if (difficulty > 0 && Input.GetMouseButton (0) && Input.GetKey (KeyCode.LeftControl))
				this.transform.Rotate (new Vector3 (0.0f, Input.mousePosition.x - oldPos.x, 0.0f));
			else if (difficulty > 1 && Input.GetMouseButton (0) && Input.GetKey (KeyCode.LeftShift))
				this.transform.Translate (new Vector3 (0.0f, 0.0f, (Input.mousePosition.x - oldPos.x) / 10.0f), Space.World);
			else if (Input.GetMouseButton (0))
				this.transform.Rotate (new Vector3 (Input.mousePosition.x - oldPos.x, 0.0f, 0.0f));
		}
		oldPos = Input.mousePosition;
	}
}
