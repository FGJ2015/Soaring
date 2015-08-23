using UnityEngine;
using System.Collections;

public class ScoreC : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Player_Damage.HP <= 0)
        {
            Application.LoadLevel("Failure Scene");
        }
	}
}
