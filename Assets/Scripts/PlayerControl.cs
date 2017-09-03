using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof(Rigidbody))]
public class PlayerControl : MonoBehaviour {
    Vector3 velocity;
    Rigidbody myRigidbody;

	void Start () {
        myRigidbody = GetComponent<Rigidbody>();
	}

    public void Move(Vector3 _velocity)
    {
        velocity = _velocity;
    }

    public void LookAt(Vector3 lookAtPoint)
    {
        Vector3 hightCorrectedPoint = new Vector3(lookAtPoint.x, transform.position.y, lookAtPoint.z);
        transform.LookAt(hightCorrectedPoint);
    }

    public void FixedUpdate()
    {
        myRigidbody.MovePosition(myRigidbody.position + velocity * Time.fixedDeltaTime);
    }
}
