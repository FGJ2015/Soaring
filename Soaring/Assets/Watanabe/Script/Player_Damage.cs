using UnityEngine;
using System.Collections;

public class Player_Damage : MonoBehaviour {


	public static int HP = 3;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		//Debug.Log(HP);
		if(HP<=0){
			HP=0;
		}
	}

}
