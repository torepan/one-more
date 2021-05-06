using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PillarJudgment : MonoBehaviour
{
    public float zoom = 0.1f; // 初期の敵の表示倍率
    public float zoom_dec = 0.1f; // 倍率の減少幅
    [SerializeField]
    GameObject PillarObject;
    [SerializeField]
    GameObject PillarScore;

    [SerializeField] float RandomLower_X=-5.0f;
    //茎のx座標のランダム範囲の上限
    [SerializeField] float RandomUpper_X=6.0f;
    //茎のz座標のランダム範囲の下限
    [SerializeField] float RandomLower_Z=1.0f;
    //茎のz座標のランダム範囲の上限
    [SerializeField] float RandomUpper_Z=9.0f;
    //茎の本数のランダム範囲の下限
    [SerializeField]　int RandomLower_Number=1;
    //茎の本数のランダム範囲の上限
    [SerializeField]　int RandomUpper_Number=3;
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
            zoom += zoom_dec; // 倍率を大きくする
            transform.localScale = new Vector3(2, zoom, 2);
            PillarScore.GetComponent<ScoreScript>().ScorePlus();
            RandomPillar();
        }
    }

    private void CreatePillar(){
        //茎のx座標をランダムで決める
        float Px =  Random.Range(RandomLower_X,RandomUpper_X);
        //茎のz座標をランダムで決める
        float Pz =  Random.Range(RandomLower_Z,RandomUpper_Z);
        GameObject PillarPlacement=Instantiate(PillarObject);
        //茎をランダムな位置に配置
        PillarPlacement.transform.position=new Vector3(Px,1.09f,Pz);
        }

     private void RandomPillar(){
        //茎の本数をランダムで決める
        int n=Random.Range(RandomLower_Number,RandomUpper_Number+1); 
        //countのC
        int c=0;
        //ランダムで決めた本数分配置
        while(c<n){
        //ランダムに茎を配置
        CreatePillar();
        c=c+1;
        }
        Debug.Log(n);
    }
}
