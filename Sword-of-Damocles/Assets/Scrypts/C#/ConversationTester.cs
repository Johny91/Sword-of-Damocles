using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ConversationTester : MonoBehaviour {

    //public Canvas canvas;

	// Use this for initialization
	void Start () {
	    GetComponentInParent<Text>().text = "It twerks";
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnDisable()
    {
        Debug.Log("It REALLY twerks");
    }
}
