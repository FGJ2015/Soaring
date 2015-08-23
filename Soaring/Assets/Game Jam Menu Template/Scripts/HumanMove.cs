using UnityEngine;
using System.Collections;

public class HumanMove : MonoBehaviour {

    float t=0;
    float d=60;
    public float speed = 0.1f;
    Vector3 firspos;
	// Use this for initialization
	void Start () {
        firspos = this.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        t += Time.deltaTime;
        d-=speed;
        if (t >= 360) { t = 0.0f; }

        this.transform.position  = new Vector3(firspos.x,50+Mathf.Sin(t)*5, firspos.z);

        if(d<=-100){
            Destroy(this.gameObject);
        }
	}

}
