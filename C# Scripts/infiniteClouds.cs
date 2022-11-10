using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class infiniteClouds : MonoBehaviour {
    public float speed = 5;

    void Start() {
    }

    void Update() {
        transform.position += new Vector3(-speed * Time.deltaTime, 0);

        if (transform.position.x < -23.05f) {
            transform.position = new Vector3(23.05f, transform.position.y);
        }
    }
}
