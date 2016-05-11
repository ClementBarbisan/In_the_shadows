using UnityEngine;
using System.Collections;

public class renderPlane : MonoBehaviour {
	public RenderTexture renderTex;
	public Material currentMat;
	Renderer render;
	// Use this for initialization
	void Awake () {
		render = GetComponent<Renderer> ();

	}

	// Update is called once per frame
	void Update () 
	{
//		render.material = currentMat;
//		render.material.SetTexture ("_CausticTex", renderTex);
		render.material.mainTexture = renderTex;
	}
}
