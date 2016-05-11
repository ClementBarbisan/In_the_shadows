using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public class manager : MonoBehaviour {
	public Material material;
	
	// Creates a private material used to the effect
	void Awake ()
	{
	}

	void Update()
	{

	}

	// Postprocess the image
	void OnRenderImage (RenderTexture source, RenderTexture destination)
	{
		Graphics.Blit (source, destination, material);
	}
}
