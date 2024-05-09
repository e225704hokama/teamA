using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin_test999 : MonoBehaviour
{
    private float speed = 6.0f;
    void Update()
    {
       transform.Translate(Vector3.left * speed * Time.deltaTime);
    }
}