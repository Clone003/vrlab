using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleToggle : MonoBehaviour
{
    [SerializeField] // Assign the particle system in editor.
 private ParticleSystem mParticles;
 /* Alternatively, you can search for it by name
 or if using a different method, by tag.
 void Awake()
 {
 mParticles = GameObject.Find("Fire").GetComponent<ParticleSystem>();
 }
 */
 void OnMouseUp()
 {
 if (mParticles.isStopped) {
 mParticles.Play();
 } else {
 mParticles.Stop();
 }
 }
}
