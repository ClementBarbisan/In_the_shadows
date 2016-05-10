using UnityEngine;
using System.Collections;

public class buttons : MonoBehaviour {
	public int level;
	public int difficulty;

	// Use this for initialization
	void Start () {
	
	}
	
	public void loadScene()
	{
		PlayerPrefs.SetInt ("level", level);
		PlayerPrefs.SetInt ("difficulty", difficulty);
		PlayerPrefs.Save ();
		Application.LoadLevel ("scene");
	}

	// Update is called once per frame
	void Update () {
	
	}
}
