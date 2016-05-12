using UnityEngine;
using System.Collections;

public class successButtons : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	public void resetSave()
	{
		PlayerPrefs.DeleteAll ();
	}

	public void returnToMenu()
	{
		PlayerPrefs.SetInt ("fromScene", 1);
		Application.LoadLevel ("menu");
	}

	public void Quit()
	{
		PlayerPrefs.SetInt ("fromScene", 0);
		Application.Quit ();
	}

	// Update is called once per frame
	void Update () {
	
	}
}
