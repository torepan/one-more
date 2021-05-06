using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PillarSpawnScript : MonoBehaviour
{
    //茎のPrefabをPrefab_Pillarを入れると動きます。
    public GameObject PrefabPillar;
    //茎のx座標のランダム範囲の下限
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

    
    
    void Start()
    {
        RandomPillar();
    }
    //ランダムに茎を配置するメソッド
    //配置する詳細の設定はまだしていない
    private void CreatePillar(){
        //茎のx座標をランダムで決める
        float Px =  Random.Range(RandomLower_X,RandomUpper_X);
        //茎のz座標をランダムで決める
        float Pz =  Random.Range(RandomLower_Z,RandomUpper_Z);
        GameObject PillarPlacement=Instantiate(PrefabPillar);
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
    // Update is called once per frame
    void Update()
    {

    }
}
