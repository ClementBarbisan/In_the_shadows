using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class checkSuccess : MonoBehaviour {
	public List<collider> list;
	public bool success = false;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		for (int i = 0; i < list.Count; i++)
		{
			if (list[i].inside && i == list.Count - 1)
				success = true;
			else if (!list[i].inside)
				break;
		}
		if (success)
			this.gameObject.SetActive (false);
	}
}
