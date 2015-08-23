using UnityEngine;
using System.Collections;
using System.IO;
using System;

public class Fx : MonoBehaviour {
    //private float gameObject;
   //gameOBject
    public GameObject[] obj;
    public string[] tags;
    bool flg = false;
    GameObject[] particles;

    public int particle_life = 2;
    int a = 0;
    int i = 0;


    void Start()
    {
        a = 0;
    }

    void Update()
    {
      
    }
	void  OnTriggerEnter(Collider col){
     //  duration = GetComponent<ParticleSystem>().duration;
       // Destroy(gameObject, duration);
        try
        {
            for (i = 0; i < tags.Length; i++)
            {
                if (col.gameObject.tag == tags[i])
                {
                    particles[a] = (GameObject)Instantiate(obj[i], this.transform.position, this.transform.rotation);
                   // Destroy(particles[a], 2);  
                    

                    flg = true;
                }
            }
        }
        catch (Exception e)
        {
            Debug.Log("A");
        }
        Destroy(col.gameObject);
	}

    void OnTriggerExit(Collider col)
    {
        flg = false;
    }
}
	