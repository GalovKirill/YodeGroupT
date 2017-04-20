using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeCreater : MonoBehaviour {

    public GameObject cube;
    int count = 0;
	
	void Start ()
    { 
       StartCoroutine(instCube());  	
	}
	IEnumerator instCube()
    {
        while (count < 20)
        {
            yield return new WaitForSeconds(2f);
            Instantiate(cube, new Vector3(Random.Range(-9f, -3f), Random.Range(0f, 2f), Random.Range(-12f, -6f)), Quaternion.identity);
            count++;
        }
    }
	void Update ()
    {
        
	}
    
}
