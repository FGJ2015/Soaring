using UnityEngine;
using System.Collections;

public class Bird_Move : MonoBehaviour {

	//Vector3  delta;
	public float speed = 0.5f;
	Transform player;


	// Use this for initialization
	void Start () {
		player = GameObject.FindWithTag("Player").transform;
		//delta = new Vector3(Random.Range(player_position.position.x+20,player_position.position.x-20),Random.Range(player_position.position.y+5,player_position.position.y-5),Random.Range(player_position.position.z-10,player_position.position.z+10));
		Vector3 deltapos = player.position - this.transform.position+new Vector3(Random.Range(-10,10),0,Random.Range(-10,10));
		Quaternion rotation = Quaternion.LookRotation(deltapos);
		transform.rotation = rotation;
	}
	
	// Update is called once per frame
	void Update () {
		this.gameObject.transform.position += this.transform.forward*speed;
		Destroy(this.gameObject,10);
		if(this.gameObject.transform.position.y<=-1.0f){
			Destroy(this.gameObject);
		}
	}
}
