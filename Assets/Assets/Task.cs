using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task : Node {

    public GameObject objetivo;
    public Rigidbody rig;

	// Use this for initialization
	void Start () {
        children = new Node[0];
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Desplazarse ()
    {
        gameObject.transform.position = objetivo.transform.position;
    }

    public void Saltar()
    {

    }
}
