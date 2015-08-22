using UnityEngine;
using System.Collections;

using UnityEngine.UI;

public class Quota : MonoBehaviour
{
    void Update()
    {
        GetComponent<Text>().text = "Quotas : " + GameObject.FindGameObjectsWithTag("A");
    }
}