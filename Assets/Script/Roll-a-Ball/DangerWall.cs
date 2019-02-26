using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DangerWall : MonoBehaviour {

    //オブジェクトと接触したときに呼ばれる
    void OnCollisionEnter(Collision hit){

        if (hit.gameObject.CompareTag("Player")){ 
            //現在のシーンの番号を取得
            int sceneIndex = SceneManager.GetActiveScene().buildIndex;

            //現在のシーンを再読み込みをする
            SceneManager.LoadScene(sceneIndex);
        }
    }
}
