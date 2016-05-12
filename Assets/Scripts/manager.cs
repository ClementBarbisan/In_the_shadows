using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public class manager : MonoBehaviour {
	public Material material;
	public GameObject menu;
	public GameObject levels;
	
	// Creates a private material used to the effect
	void Awake ()
	{
		if (PlayerPrefs.GetInt ("fromScene") == 1) 
		{
			menu.gameObject.SetActive(false);
			levels.gameObject.SetActive(true);
		} 
		else 
		{
			menu.gameObject.SetActive(true);
			levels.gameObject.SetActive(false);
		}
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
