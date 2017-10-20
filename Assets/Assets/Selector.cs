using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selector : Composite {

    private bool distanciavalida = false;
    private Task taker = new Task();
    private bool check;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public bool Check()
    {
        return check;
    }

    public bool Evaluar()
    {
        return distanciavalida;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Objetivo")
        {
            distanciavalida = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Objetivo")
        {
            distanciavalida = false;
        }
    }

    public void Desplazamiento()
    {
        if (distanciavalida)
        {
            taker.Desplazarse();
            check = true;
        }
    }

    
}
