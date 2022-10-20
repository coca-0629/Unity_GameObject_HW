using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Wall_Collision : MonoBehaviour
{
    public GameObject ball;
    public Text text;
 
    void OnCollisionEnter(Collision collided) {

        this.GetComponent<AudioSource>().Play();
        text.enabled = true;

    }
}
