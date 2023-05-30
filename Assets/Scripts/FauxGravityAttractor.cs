using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FauxGravityAttractor : MonoBehaviour
{
    public float gravity = -10;
    public void Attract(GameObject body)
    {
        Vector3 gravityUp = (body.transform.position - transform.position).normalized;
        Vector3 bodyUP = body.transform.up;

        body.GetComponent<Rigidbody>().AddForce(gravityUp * gravity);

        Quaternion targetRotation = Quaternion.FromToRotation(bodyUP, gravityUp) * body.transform.rotation;
        body.transform.rotation = Quaternion.Slerp(body.transform.rotation, targetRotation, 50 * Time.deltaTime);


    }
}
