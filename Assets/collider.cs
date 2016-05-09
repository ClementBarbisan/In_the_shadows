using UnityEngine;
using System.Collections;

public class collider : MonoBehaviour {
	public int index;
	public bool inside = false;
	Renderer render;
	// Use this for initialization
	void Start () 
	{
		render = GetComponent<Renderer> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (inside)
			render.material.color = Color.green;
		else
			render.material.color = Color.red;
	}

	void OnTriggerStay(Collider other)
	{
		if (other.tag == "sphere_" + index)
			inside = true;
	}

	void OnTriggerExit(Collider other)
	{
		if (other.tag == "sphere_" + index)
			inside = false;
	}
}
