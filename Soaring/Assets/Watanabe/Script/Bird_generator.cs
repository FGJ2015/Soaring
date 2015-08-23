using UnityEngine;
using System.Collections;

public class Bird_generator : MonoBehaviour {

	//GameObject[] Bird = new GameObject[10];
	public GameObject ins_obj;
	 GameObject player;
	//Bird_Move Birdmove;

	int i=0;
	public float interval=1.0f;
	int Bird_number=5;
	float j=0.0f;
	bool flg;

	// Use this for initialization
	//void Start () {
		/*for(i=0;i<Bird_number;i++){
			Bird[i]=(GameObject)Instantiate(ins_obj,new Vector3(10000,-1000,10000));
			Bird[i].SetActive(false);
		}*/
	//}
	
	// Update is called once per frame
	IEnumerator Start() {
		while(true){
			Vector3 vec;
			player = GameObject.FindWithTag("Player");
			vec = new Vector3(Random.Range(player.transform.position.x-60,player.transform.position.x+60),Random.Range(player.transform.position.y+5,player.transform.position.y-5),Random.Range(player.transform.position.z+60,player.transform.position.z-60));
			//Instantiate(ins_obj,vec,this.ins_obj.transform.rotation);
			Instantiate(ins_obj,vec,this.ins_obj.transform.rotation);
			yield return new WaitForSeconds(interval);
		}
		yield return null;
	}
}