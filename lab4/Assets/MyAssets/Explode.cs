using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explode : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private GameObject Sphere;
    private ParticleSystem Explosion;
    void Start()
    {
        Explosion = Sphere.transform.GetChild(0).GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.Mouse2)) {
            StartCoroutine(Active());
        }
    }
    IEnumerator Active() {
        Explosion.Play();
        yield return new WaitForSeconds(1);
        Explosion.Stop();
        Destroy(Sphere);
    }
}
