using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    // Start is called before the first frame update
    public float timeBeforeNextFire, fireRate, shootForce;
    public GameObject fireball, icelance;
    public Camera myCamera;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0) && Time.time > timeBeforeNextFire) {
            GameObject clone = Instantiate(fireball, fireball.transform.position, myCamera.transform.rotation);
            clone.SetActive(true);
            Rigidbody cloneRB = clone.GetComponent<Rigidbody>();
            cloneRB.AddForce(myCamera.transform.forward * shootForce);
            timeBeforeNextFire = Time.time + fireRate;
        }
        else if(Input.GetKeyDown(KeyCode.Mouse1) && Time.time > timeBeforeNextFire) {
            GameObject clone = Instantiate(icelance, icelance.transform.position, myCamera.transform.rotation);
            clone.SetActive(true);
            Rigidbody cloneRB = clone.GetComponent<Rigidbody>();
            cloneRB.AddForce(myCamera.transform.forward * shootForce);
            timeBeforeNextFire = Time.time + fireRate;
        }
    }
}
