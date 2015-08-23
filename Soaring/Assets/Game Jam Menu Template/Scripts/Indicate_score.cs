using UnityEngine;
using System.Collections;

public class Indicate_score : MonoBehaviour {

    GUIText gui;
 
	// Use this for initialization
	void Start () {
        gui = this.GetComponent<GUIText>();
	}
	
	// Update is called once per frame
	void Update () {
        gui.text = "Your Score is " + Player_ItemGet.Point;
	}
}
