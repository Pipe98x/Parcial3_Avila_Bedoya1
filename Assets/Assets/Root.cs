using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Root : Node {
    public Sequence secu = new Sequence();
	// Use this for initialization
	void Start () {
        children = new Node[1];
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public override bool Execute()
    {
        return base.Execute();
    }
    

}
