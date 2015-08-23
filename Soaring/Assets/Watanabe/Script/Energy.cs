using UnityEngine;
using System.Collections;

public class Energy : MonoBehaviour {
	bool flg = false;
	// Use this for initialization
	void Start () {
        flg = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider col){
		if(flg == false){
		if(col.gameObject.tag=="Player"){
			//Event();
            Player_ItemGet.Point++;
            flg = true; Destroy(this.gameObject);
		}
	 	}
	}

	//This event occers when player hits energy object
	void Event(){
		Player_ItemGet.Point++;
	}

}
