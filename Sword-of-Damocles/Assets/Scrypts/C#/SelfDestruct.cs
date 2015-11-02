using UnityEngine;
using System.Collections;

public class SelfDestruct : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Debug.Log("Done");
        this.enabled = false;        
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter(Collision collision)
    {
        GameObject.Destroy(this.gameObject);
    }
}
