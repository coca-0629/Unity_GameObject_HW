using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rigid_body : MonoBehaviour
{
    //float power = 1000;  // 수치 수정 (1000 -> 500)
    float power = 500;

    void Update()
    {
        if(Input.GetKey(KeyCode.UpArrow))
            GetComponent<Rigidbody>().AddForce(Vector3.forward * power * Time.deltaTime);
        if(Input.GetKey(KeyCode.DownArrow))
            GetComponent<Rigidbody>().AddForce(Vector3.back * power * Time.deltaTime);
        if(Input.GetKey(KeyCode.LeftArrow))
            GetComponent<Rigidbody>().AddForce(Vector3.left * power * Time.deltaTime);
        if(Input.GetKey(KeyCode.RightArrow))
            GetComponent<Rigidbody>().AddForce(Vector3.right * power * Time.deltaTime);
        if(Input.GetKey(KeyCode.U))
            GetComponent<Rigidbody>().AddForce(Vector3.up * power * Time.deltaTime);
        if(Input.GetKey(KeyCode.D))
            GetComponent<Rigidbody>().AddForce(Vector3.down * power * Time.deltaTime);
    }
}
