using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WandActive : MonoBehaviour
{
    [SerializeField] private ParticleSystem mParticles;
    /* Alternatively, you can search for it by name
    or if using a different method, by tag.
    void Awake()
    {
    mParticles = GameObject.Find("Fire").GetComponent<ParticleSystem>();
    }
    */
    void Update() {
        if (Input.GetKeyDown(KeyCode.Mouse0) || Input.GetKeyDown(KeyCode.Mouse1)) {
            StartCoroutine(Active());
        }
    }

    IEnumerator Active() {
        mParticles.Play();
        yield return new WaitForSeconds(1);
        mParticles.Stop();
    }
}
