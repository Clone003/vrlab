using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpookyLight : MonoBehaviour
{
    public float speed = 2.0f;
    float traveled = 0.0f;
    public float distance = 15.0f;
    void Update()
    {
        traveled += Time.deltaTime * speed;
        if (traveled >= distance || traveled <= (-1 * distance)) {
            speed *=  -1;
            traveled = 0.0f;
        }
        transform.Translate(Vector3.back * Time.deltaTime * speed);
    }

}
