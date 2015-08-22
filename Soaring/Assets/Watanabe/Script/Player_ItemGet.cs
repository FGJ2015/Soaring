using UnityEngine;
using System.Collections;

public class Player_ItemGet: MonoBehaviour {

	public static int Point;

	// Use this for initialization
	void Start () {
		Point = 0;
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log(Point);
	}
}
