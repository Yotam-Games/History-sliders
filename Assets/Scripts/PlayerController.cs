using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 15;
    private Vector3 moveDir;

    private void Update()
    {
        moveDir = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical")).normalized;
    }

    private void FixedUpdate()
    {
        Rigidbody myRigidBody = GetComponent<Rigidbody>();
        myRigidBody.MovePosition(myRigidBody.position + transform.TransformDirection(moveDir) * moveSpeed * Time.deltaTime);
    }
}
