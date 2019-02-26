using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

    public Text scoreLabel;
    public GameObject winnerLabelObject;
    
	void Update () {
        int count = GameObject.FindGameObjectsWithTag("Item").Length;
        scoreLabel.text = count.ToString();

        if(count == 0){
            //クリア時
            winnerLabelObject.SetActive(true);
        }
	}
}

