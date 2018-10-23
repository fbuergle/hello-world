using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class virtualModelActions : MonoBehaviour {

    //The cube which shall be clickable
    public GameObject myModel;
    public Material material1;
    public Material material2;

    //My textbox for debugging stuff
    public Text textbox;
    private int counter = 1;

    //global variable to save the material assigned to the myModel
    private Material currentMaterial;

    
    // Use this for initialization
    void Start()
    {
        textbox.text += "MyModel says Hello";

        currentMaterial = material1;

    }

    // Update is called once per frame
    void Update()
    {
        //if my Model was clicked, lets change it's material
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                textbox.text = "MyModel was clicked withMouseDown" + counter;
                counter++;

                myModel.GetComponent<Renderer>().material = currentMaterial;
                //Change currentMaterial to the other one (not the one that currently is the currentMaterial)
                currentMaterial = (currentMaterial == material1) ? material2 : material1;
            }
        }
    }
}
