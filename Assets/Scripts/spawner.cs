using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class spawner : MonoBehaviour {
	int level;
	public List<GameObject> list;
	// Use this for initialization
	void Start () {
		level = PlayerPrefs.GetInt("level");
		if (level < list.Count) {
			GameObject.Instantiate<GameObject>(list[level]);		
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
