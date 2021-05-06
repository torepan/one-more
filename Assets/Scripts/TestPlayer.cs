using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestPlayer : MonoBehaviour
{
    private Vector3 latestPos;  //�O���Position
    public GameObject GameObject;

    void Update()
    {
        Vector3 diff = transform.position - latestPos;   //�O�񂩂�ǂ��ɐi�񂾂����x�N�g���Ŏ擾
        latestPos = transform.position;  //�O���Position�̍X�V

        // ���Ɉړ�
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += new Vector3(-5 * Time.deltaTime, 0, 0);
        }
        // �E�Ɉړ�
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += new Vector3(5 * Time.deltaTime, 0, 0);
        }
        // �O�Ɉړ�
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += new Vector3(0, 0, 5 * Time.deltaTime);
        }
        // ���Ɉړ�
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += new Vector3(0, 0, -5 * Time.deltaTime);
        }

        if (diff.magnitude > 0.01f)
        {
            transform.rotation = Quaternion.LookRotation(diff); //������ύX����
        }

        /*if (Input.GetKey(KeyCode.S))
        {
            GameObject.GetComponent<ScoreScript>().ScorePlus();
        }*/
    }
}
