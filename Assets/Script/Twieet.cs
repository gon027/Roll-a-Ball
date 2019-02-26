using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Twieet : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            Application.OpenURL("http://twitter.com/intent/tweet?text=" + WWW.EscapeURL("テスト"));
        }
		
	}
}
