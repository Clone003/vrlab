using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Force : MonoBehaviour
{

    // Using the attribute SerializeField, we can expose a private
    // variable in the inspector window!
    [SerializeField]
    private float thrust = 10f;
    // This does not have the attribute, so it will not be exposed.
    private Rigidbody mRigid;
    void Awake() {
        mRigid = GetComponent<Rigidbody>();
        // Alternatively:
        // mRigid = GetComponent<Rigidbody>();
    }
    void FixedUpdate() {
        mRigid.AddForce(Vector3.forward * thrust);
    }
}