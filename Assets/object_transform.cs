using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class object_transform : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown (KeyCode.A))
        {
            float rnd = Random.Range(-0.2f, 0.2f);
            this.transform.position += new Vector3(rnd, rnd, rnd);  // this�� ��ũ��Ʈ�� ����� ��ü�� �ǹ�, ���� ����
        }

        if (Input.GetKeyDown(KeyCode.B))
        {
            float rnd = Random.Range(0.0f, 360.0f);
            // this.transform.rotation = Quaternion.Euler (rnd, 0.0f, 0.0f);  // 회전 축 수정 (X -> Y)
            this.transform.rotation = Quaternion.Euler (0.0f, rnd, 0.0f);  // this�� ��ũ��Ʈ�� ����� ��ü�� �ǹ�, ���� ����
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            float rnd = Random.Range(0.5f, 1.5f);
            this.transform.localScale = new Vector3 (rnd, rnd, rnd);  // this�� ��ũ��Ʈ�� ����� ��ü�� �ǹ�, ���� ����
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            // this.transform.Translate(new Vector3(0.0f, 0.0f, 0.3f) * Time.deltaTime)
            this.transform.Translate(Vector3.forward * 3.0f * Time.deltaTime);  // Vector3.forward = Vector3(0.0f, 0.0f, 1.0f)
        }

        if (Input.GetKey(KeyCode.R))
        {
            //this.transform.Rotate(90.0f * Time.deltaTime, 0.0f, 0.0f);  // 회전 축 수정 (X -> Y)
            this.transform.Rotate(0.0f, 90.0f * Time.deltaTime, 0.0f);  // this�� ��ũ��Ʈ�� ����� ��ü�� �ǹ�, ���� ����
        }
    }
}
