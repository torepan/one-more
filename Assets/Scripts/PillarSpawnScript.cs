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
    
    
    void Start()
    {
        //ランダムに茎を配置
        CreatePillar();
    }
    //ランダムに茎を配置するメソッド
    //配置する詳細の設定はまだしていない
    private void CreatePillar(){
        //茎のx座標をランダムで決める
        float x =  Random.Range(RandomLower_X,RandomUpper_X);
        //茎のz座標をランダムで決める
        float z =  Random.Range(RandomLower_Z,RandomUpper_Z);
        GameObject PillarPlacement=Instantiate(PrefabPillar);
        //茎をランダムな位置に配置
        PillarPlacement.transform.position=new Vector3(x,1.44f,z);
        }

    // Update is called once per frame
    void Update()
    {
        
    }
}
