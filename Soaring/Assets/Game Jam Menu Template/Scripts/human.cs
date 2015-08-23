using UnityEngine;
using System.Collections;

public class human : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (count.count_1 >= 5)
        {
            Application.LoadLevel("Clear");
        }
	
	}
    void OnTriggerStay(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            count.count_1++;
        }
    }
}
