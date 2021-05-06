using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PillarJudgment : MonoBehaviour
{
    public float zoom = 0.1f; // 初期の敵の表示倍率
    public float zoom_dec = 0.1f; // 倍率の減少幅
    // Start is called before the first frame update
    void Start()
    {
        transform.localScale = new Vector3(2, zoom, 2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        // Pillarに衝突したオブジェクトのTagが "TeaPillar" だった場合
        if ( collision.gameObject.tag == "TeaPillar" )
        {
            // 衝突したプレイヤーの弾の GameObject を消滅させる
            Destroy(collision.gameObject);
            zoom += zoom_dec; // 倍率を小さくする
            transform.localScale = new Vector3(2, zoom, 2);
        }
    }
}
