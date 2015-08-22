using UnityEngine;
using System.Collections;

public class Player_Damage : MonoBehaviour {


	public static int HP = 3;
    public GUIText scoreGUI;
    public GameObject scoreObject;
	// Use this for initialization
	void Start () {
        scoreGUI = scoreObject.GetComponent<GUIText>();
	}
	
	// Update is called once per frame
	void Update () {
		//Debug.Log(HP);
		if(HP<=0){
			HP=0;
		}
        scoreGUI.text = "残機：" + HP;
	}

}
