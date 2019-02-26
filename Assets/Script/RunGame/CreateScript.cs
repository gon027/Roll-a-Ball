using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateScript : MonoBehaviour {

    public GameObject green1;
    public GameObject green2;

    public GameObject Items;

    public static int border = 0;

    float range_x = 1.5f;

    private void Start(){
        //アイテムをランダムに生成する
        for (int i = 0; i < 7; i++)
        {
            float x = Random.Range(-1.75f, 1.75f);
            float z = Random.Range(-80.0f, 0.0f);
            Instantiate(Items, new Vector3(x, 1.0f, z), Quaternion.Euler(1, 1, 1));
        }
    }

    void Update () {
		if(transform.position.z > border){
            createMap();
        }
	}

    void createMap(){
        int r = 100;

        if(green1.transform.position.z < border){
            border += r;
            Vector3 temp = new Vector3(0, 0, border);
            green1.transform.position = temp;
            createItems();
        }
        else if(green2.transform.position.z < border){
            border += r;
            Vector3 temp = new Vector3(0, 0, border);
            green2.transform.position = temp;
            createItems();
        }
    }

    void createItems() {
        //アイテムをランダムに生成する
        for (int i = 0; i < 7; i++) {
            float x = Random.Range(-1.75f, 1.75f);
            float z = Random.Range(-80.0f + CreateScript.border, 0.0f + CreateScript.border);
            Instantiate(Items, new Vector3(x, 1.0f, z), Quaternion.Euler(1, 1, 1));
        }

    }
}
