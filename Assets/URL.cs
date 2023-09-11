using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class URL : MonoBehaviour {

	// Use this for initialization
    void Start()
    {

    }

    public void btnOne()
    {
        Application.OpenURL("http://lightsources.ir");
    }

    public void btnTwo()
    {
        Application.OpenURL("http://www.ikiu.ac.ir");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
