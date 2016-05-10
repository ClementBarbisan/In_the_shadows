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
		Application.LoadLevel ("menu");
	}

	public void Quit()
	{
		Application.Quit ();
	}

	// Update is called once per frame
	void Update () {
	
	}
}
