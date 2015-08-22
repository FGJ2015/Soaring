using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TergetRemaining : MonoBehaviour {

	// Use this for initialization
	void Start () {
     
	}
	
	// Update is called once per frame
	void Update () {
	   GetComponent<Text>().text = "ノルマ;" + GameObject.FindGameObjectsWithTag("Terget").Length;
	}
}
