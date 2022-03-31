using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    Rigidbody mRigid;
    Vector3 m_EulerAngleVelocity;
    public float speed = 1.0f;
    void Start() {
        mRigid = GetComponent<Rigidbody>();
        m_EulerAngleVelocity = new Vector3(0, 180, 0);
    }
    // Update is called once per frame
    void FixedUpdate() {
        Quaternion deltaRotation = Quaternion.Euler(m_EulerAngleVelocity * Time.fixedDeltaTime);
        mRigid.MoveRotation(mRigid.rotation * deltaRotation);
    }
}
