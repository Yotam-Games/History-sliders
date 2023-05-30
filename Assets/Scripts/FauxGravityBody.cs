using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FauxGravityBody : MonoBehaviour
{
    public FauxGravityAttractor attractor;
    public Rigidbody myRigidbody;
    private GameObject myGameobject;
    

    void Start()
    {
        myRigidbody.constraints = RigidbodyConstraints.FreezeRotation;
        myRigidbody.useGravity = false;
        myGameobject = this.gameObject;
        
    }

    // Update is called once per frame
    void Update()
    {
        attractor.Attract(myGameobject);
    }
}
