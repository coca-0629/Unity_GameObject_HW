using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object_Collision : MonoBehaviour
{
    public GameObject Plane;

    void OnCollisionEnter(Collision collided) {
        this.GetComponent<AudioSource>().Play();
        Debug.Log(collided.gameObject.name);

        if (collided.gameObject == Plane)
            this.GetComponent<Rigidbody>().AddForce(new Vector3(0, 1, 1) * 50.0f);
    }
}
