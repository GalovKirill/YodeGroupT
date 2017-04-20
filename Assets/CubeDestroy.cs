using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//[RequireComponent(typeof(Collider))]
public class CubeDestroy : MonoBehaviour {

    
	// Use this for initialization
	void Start () {
        

    }
	
	// Update is called once per frame
	void Update () {
		
	}
    public void Stop()
    {
        Destroy(gameObject);
    }
    public void Destr()
    {
        GetComponent<Renderer>().material.color = Color.red;
        Destroy(gameObject, 0.75f);
    }
}
