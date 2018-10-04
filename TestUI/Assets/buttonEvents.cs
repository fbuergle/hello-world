using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class buttonEvents : MonoBehaviour {
	
	//https://docs.unity3d.com/ScriptReference/UI.Button-onClick.html
	public Button m_YourFirstButton;
	public GameObject mySphere;
	
	
	//To not add all cubes at the very same position
	private float pos = 4.0f;
	
	// Use this for initialization
	void Start () {
		//myButton.GetComponent<myButton>().onClick.AddListener(() => {Sphere.transform.position.x = 2;});
		
		Button btn1 = m_YourFirstButton.GetComponent<Button>();

        //Calls the TaskOnClick/TaskWithParameters method when you click the Button
        btn1.onClick.AddListener(TaskOnClick);
		
	}
	
	// Update is called once per frame
	void Update () {
		//https://answers.unity.com/questions/779226/unity-46-getcomponentonclick-how-do-you-add-an-eve.html
		//myButton.GetComponent<Button>().onClick.AddListener(() => { someFunction(); otherFunction(); }
		
		
		//Instantiate(Sphere, myposition.transform.position, myposition.transform.rotation);
	}
	
	void TaskOnClick(){
		Debug.Log("BUtton was clicked");
		//btn1.TextWriter("Hello World");
		//mySphere.transform.position.x = 3;
		GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
		sphere.transform.Translate (4.0f,4.0f,0.0f);
		sphere.GetComponent<MeshFilter>().mesh = new Mesh();
		
		
		GameObject Kube = GameObject.CreatePrimitive(PrimitiveType.Cube);
		Kube.transform.Translate (pos,pos,pos);
		pos += 1.0f;
		/*
		Mesh mesh = new Mesh();
        GetComponent<MeshFilter>().mesh = mesh;
        mesh.vertices = newVertices;
        mesh.uv = newUV;
        mesh.triangles = newTriangles;
		*/
		//float xpos = 0.3f;
		//sphere.transform.position.x = xpos;
	}
}
