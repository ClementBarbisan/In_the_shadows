using UnityEngine;
using System.Collections;

public class menuButtons : MonoBehaviour {
	public string mode;
	public GameObject other;
	public GameObject self;
	// Use this for initialization
	void Awake () {
	}

	public void showCanvas()
	{
		PlayerPrefs.SetString ("mode", mode);
		other.gameObject.SetActive(true);
		self.gameObject.SetActive(false);
	}
	// Update is called once per frame
	void Update () {
	
	}
}
