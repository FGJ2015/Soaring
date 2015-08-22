using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Quotas : MonoBehaviour {
   
    public int Quitacount=count.count_1;
    public Canvas canvas;
    // Use this for initialization
    void Start()
    {
       
    }
	// Update is called once per frame
	void Update () {
	 Text target = null;
        foreach (Transform child in canvas.transform)
        {
            if (child.name == "Text")
            {
                target = child.gameObject.GetComponent<Text>();
                target.text = "Quotas :"+count.count_1;

            }
        }
	}
}
