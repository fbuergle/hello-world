using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class click1Actions : MonoBehaviour {
    
    //The object which shall be clickable
    public GameObject clickableMe;

    //My textbox for debugging stuff
    public Text textbox;
    private int counter = 1;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            textbox.text = "Mouse down ";
            if (Physics.Raycast(ray, out hit))
            {
                textbox.text += "Click happened " + hit.transform.name;

                if (hit.transform.name == clickableMe.name) { 
                    textbox.text += "1 was clicked !!!!" + counter;
                    counter++;
                }
            }
        }

    }
}
