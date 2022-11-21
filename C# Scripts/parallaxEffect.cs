using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class parallaxEffect : MonoBehaviour {
    public float speed = 5;
    public float offSet = 23.05f;
    void Start() {
    }

    void Update() {
        transform.position += new Vector3(-speed * Time.deltaTime, 0);

        if (transform.position.x < -offSet) {
            transform.position = new Vector3(offSet, transform.position.y);
        }
    }
}
