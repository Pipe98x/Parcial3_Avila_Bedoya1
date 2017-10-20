using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sequence : Composite {

    public Selector sele = new Selector();
    public Task tak = new Task();

	// Use this for initialization
	void Start () {
        children = new Node[2];  
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public override bool Execute()
    {

    }


}
