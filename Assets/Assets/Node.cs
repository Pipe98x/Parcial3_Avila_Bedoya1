using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Node : MonoBehaviour {

    // Use this for initialization

     protected Node[] children = new Node[0];

    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public virtual bool Execute()
    {
        return true;
          
    }
}
