using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public float speed = 100;

	void Update () {
        transform.position = new Vector3(speed * Time.deltaTime, 0f, 0f);

        if (Input.GetKey(KeyCode.RightArrow)){
            transform.position = new Vector3(speed * Time.deltaTime, 0f, 0f);
        }


	}
}
