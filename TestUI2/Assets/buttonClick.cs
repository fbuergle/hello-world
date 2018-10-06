using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buttonClick : MonoBehaviour {
	public Button m_YourFirstButton;
	
	public GameObject myCube;
	
	//x and y componentes of the newly added cube
	private float pos_x = 456.0f;
	private	float pos_y = 2.5f;
	private	float pos_z = -9.0f;
	
		
	
	// The target marker. --> myCube will move towards this
    public Transform target;
	
	// Use this for initialization
	void Start () {
		
		//Find the button
		Button btn1 = m_YourFirstButton.GetComponent<Button>();

        //Calls the TaskOnClick/TaskWithParameters method when you click the Button
        btn1.onClick.AddListener(TaskOnClick);
	}
	
	// Update is called once per frame
	void Update () {
		
		//from https://docs.unity3d.com/ScriptReference/Vector3.MoveTowards.html
        // The step size is equal to speed times frame time.
        float step = Time.deltaTime;

        // Move our position a step closer to the target.
        myCube.transform.position = Vector3.MoveTowards(myCube.transform.position, target.position, step);
    
	}

	void TaskOnClick(){
		Debug.Log("Button was clicked");
			
		//Create new cube
		GameObject Kube = GameObject.CreatePrimitive(PrimitiveType.Cube);
		Kube.transform.Translate (pos_x,pos_y,pos_z);
		pos_x -= 1.0f;
		pos_y -= 1.0f;
	}
}
