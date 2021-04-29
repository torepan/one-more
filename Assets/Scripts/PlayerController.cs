using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Vector3 latestPos;  //前回のPosition

    void Update()
    {
        Vector3 diff = transform.position - latestPos;   //前回からどこに進んだかをベクトルで取得
        latestPos = transform.position;  //前回のPositionの更新

        // 左に移動
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += new Vector3(-5 * Time.deltaTime, 0, 0);
        }
        // 右に移動
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += new Vector3(5 * Time.deltaTime, 0, 0);
        }
        // 前に移動
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += new Vector3(0, 0, 5 * Time.deltaTime);
        }
        // 後ろに移動
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += new Vector3(0, 0, -5 * Time.deltaTime);
        }

        if (diff.magnitude > 0.01f)
        {
            transform.rotation = Quaternion.LookRotation(diff); //向きを変更する
        }
    }
}
