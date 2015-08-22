using UnityEngine;
using System.Collections;

public class Bird_hit : MonoBehaviour {

	bool flg = false;
	public int damagepoint;
	//Player_Damage player_damage;

	// Use this for initialization
	void Start () {
		flg = false;
		//player_damage = GameObject.FindWithTag("Player").GetComponent<Player_Damage>();
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter(Collider col){
		if(col.gameObject.tag =="Player"){
			//Debug.Log("hit");
			if(flg==false){
			Player_Damage.HP--;
			Debug.Log(Player_Damage.HP);
				flg=true;
			}

		}
	}
}
