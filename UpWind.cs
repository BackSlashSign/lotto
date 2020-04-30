using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpWind : MonoBehaviour
{
    public float force = 1000.0f;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("trigger called");
        other.gameObject.GetComponent<Rigidbody>().AddForce(0, force, 0);
    }
}
