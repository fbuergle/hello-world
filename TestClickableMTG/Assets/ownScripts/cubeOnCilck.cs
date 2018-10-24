using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cubeOnCilck : MonoBehaviour {

    //The cube which shall be clickable
    public GameObject myCube;
    public Material material1;
    public Material material2;

    //Wo is the parent of newly added cubes
    public GameObject godfather;

    //My textbox for debugging stuff
    //public GameObject textbox;
    public Text textbox;
    private int counter = 1;
    private Material currentMaterialCube;

    void createCube(float pos_x, float pos_y)
    {
        //x and y componentes of the newly added cube
        float pos_z = -0.03576335f;
        //Create new cube
        GameObject Kube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        Kube.transform.parent = godfather.transform;
        Kube.transform.Translate(pos_x, pos_y, pos_z);

    }

    // Use this for initialization
    void Start () {
        //textbox.text += " Hello";
        currentMaterialCube = material1;
    }
	
	// Update is called once per frame
	void Update () {
        
        /*int fingerCount = 0;
        foreach (Touch touch in Input.touches)
        {
            if (touch.phase != TouchPhase.Ended && touch.phase != TouchPhase.Canceled) { 
                fingerCount++;
                //create cube where the finger touched
                createCube(touch.position.x, touch.position.y);


                //if my cube was clicked, lets change it's material
                RaycastHit hit;
                Vector3 vec;
                vec.x = touch.position.x;
                vec.y = touch.position.y;
                    vec.z = myCube.transform.position.z;
                Ray ray = Camera.main.ScreenPointToRay(new Vector3(touch.position.x, touch.position.y, -0.03576335f));

                if (Physics.Raycast(ray, out hit))
                {
                    textbox.text = "Cube was clicked " + counter + GetComponent<Renderer>().material + " material 1 " + material1;
                    counter++;
                    if (myCube.GetComponent<Renderer>().material.name != material1.name)
                    {
                        myCube.GetComponent<Renderer>().material = material1;

                    }
                    else
                    {
                        myCube.GetComponent<Renderer>().material = material2;
                    }
                }
            }
        }*/
        
        //if my cube was clicked, lets change it's material
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            textbox.text = "MouseDown";
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.name == myCube.name)
                {
                    textbox.text = "Cube was clicked withMouseDown" + counter;
                    counter++;
                    myCube.GetComponent<Renderer>().material = currentMaterialCube;
                    currentMaterialCube = (currentMaterialCube == material1) ? material2 : material1;
                    /*if (GetComponent<Renderer>().material != material1)
                    {
                        GetComponent<Renderer>().material = material1;
                    }
                    else
                    {
                        GetComponent<Renderer>().material = material2;
                    }*/
                }
            }
        }

        //Tests for playmode
        if (Input.GetButtonDown("Fire1"))
        {
            Debug.Log(Input.mousePosition);
            createCube(Input.mousePosition.x, Input.mousePosition.y);

        }
    }

   
}
