using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateScript : MonoBehaviour {

    public GameObject green1;
    public GameObject green2;

    int border = 50;
    
	void Update () {
		if(transform.position.z > border){
            createMap();
        }
	}

    void createMap(){
        if(green1.transform.position.z < border){
            border += 100;
            Vector3 temp = new Vector3(0, 0, border);
            green1.transform.position = temp;
        }else if(green2.transform.position.z < border){
            border += 100;
            Vector3 temp = new Vector3(0, 0, border);
            green2.transform.position = temp;
        }
    }
}
