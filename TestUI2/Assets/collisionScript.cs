using System.Collections;
using UnityEngine;

public class collisionScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnCollisionEnter (Collision col){
		Debug.Log("Collision happened " + col.gameObject.name);
		
		
        //Set the main Color of the Material to green
        GetComponent<Renderer>().material.shader = Shader.Find("_Color");
        GetComponent<Renderer>().material.SetColor("_Color", col.gameObject.GetComponent<Renderer>().material.color);
		//Find the Specular shader and change its Color 
        GetComponent<Renderer>().material.shader = Shader.Find("Specular");
        GetComponent<Renderer>().material.SetColor("_SpecColor", col.gameObject.GetComponent<Renderer>().material.color);
		
		//Destroy object that collided with this one
		Destroy(col.gameObject);
	}
}
