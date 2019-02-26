using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    Rigidbody rigidbody;

    public float speed = 10;
    public float jump = 100f;

    public bool _isJump = true;

    void Start(){
        rigidbody = GetComponent<Rigidbody>();
    }

    void FixedUpdate(){
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        rigidbody.AddForce(x * speed, 0, speed);

        if (GameObject.FindGameObjectWithTag("Ground")){
            _isJump = true;
        }

        if (Input.GetKeyDown("space")){
            Debug.Log("aaaa");
           if(_isJump == true) {
                Jump();
            }
        }

    }

    void Jump(){
        _isJump = false;
        rigidbody.AddForce(Vector3.up * jump);
    }
}
