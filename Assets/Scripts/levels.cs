using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class levels : MonoBehaviour {
	public buttons[] listButtons;
	// Use this for initialization
	void Awake () {
		listButtons = GetComponentsInChildren<buttons> (); 
	}

	IEnumerator wiggle(int i)
	{
		while (true) {
			for (int j = 0; j < 40; j++)
			{
				listButtons[i].transform.Rotate(new Vector3(0.0f, 0.0f, 0.15f));
				yield return null;
			}
			for (int j = 0; j < 40; j++)
			{
				listButtons[i].transform.Rotate(new Vector3(0.0f, 0.0f, -0.15f));
				yield return null;
			}
		}
	}

	void OnEnable()
	{
		if (PlayerPrefs.GetString ("mode") == "normal") {
			for (int i = 0; i < listButtons.Length; i++) {
				if (i < PlayerPrefs.GetInt ("unlock"))
				{
					listButtons[i].gameObject.GetComponentInChildren<Text>().color = Color.green;
					listButtons [i].gameObject.SetActive (true);
				}
				else if (i == PlayerPrefs.GetInt ("unlock"))
				{
					listButtons[i].gameObject.GetComponentInChildren<Text>().color = Color.black;
					listButtons [i].gameObject.SetActive (true);
					if (PlayerPrefs.GetInt("oldUnlock") != PlayerPrefs.GetInt ("unlock"))
					{
						StartCoroutine(wiggle(i));
					}
				}
				else
					listButtons [i].gameObject.SetActive (false);
			}
			PlayerPrefs.SetInt ("oldUnlock", PlayerPrefs.GetInt ("unlock"));
		} 
		else 
		{
			for (int i = 0; i < listButtons.Length; i++)
			{
				listButtons[i].gameObject.SetActive(true);
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
