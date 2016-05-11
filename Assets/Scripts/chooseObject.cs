using UnityEngine;
using System.Collections;

public class chooseObject : MonoBehaviour 
{
	public GameObject[] list;
	public checkSuccess[] listSuccess;
	public int level;
	Canvas successCanvas;
	bool success = false;
	// Use this for initialization
	void Awake () 
	{
		list = GameObject.FindGameObjectsWithTag("model");
		list[0].GetComponent<rotationObject>().choosen = true;
		successCanvas = GameObject.FindGameObjectWithTag ("successCanvas").GetComponent<Canvas>();
		successCanvas.gameObject.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (success) {
			if (PlayerPrefs.GetInt("unlock") == level)
				PlayerPrefs.SetInt("unlock", level + 1);
			PlayerPrefs.Save();
			successCanvas.gameObject.SetActive(true);
		} else {
			if (Input.GetMouseButtonDown (0)) {
				Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
				RaycastHit hit;
			
				if (Physics.Raycast (ray, out hit, 100) && hit.collider.tag == "model") {
					hit.collider.GetComponent<rotationObject> ().choosen = true;
					for (int i = 0; i < list.Length; i++) {
						if (list [i].gameObject != hit.collider.gameObject)
							list [i].GetComponent<rotationObject> ().choosen = false;
					}
				}
			}
			for (int i = 0; i < listSuccess.Length; i++) {
				if (listSuccess [i].success && i == listSuccess.Length - 1)
				{
					for (int j = 0; j < list.Length; j++) {
							list [j].GetComponent<rotationObject> ().choosen = false;
					}
					success = true;
				}
				else if (!listSuccess [i].success)
					break;
			}
		}
	}
}
