using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pigeonJump : MonoBehaviour
{
    private Animator pigeonFlyUp;
    private string animationName = "jumpMechanic";
    private Vector3 direction;
    public float gravity = -9.8f;
    public float strength = 5f;

    private void Awake() {
        
    }

    private void Start() {
        pigeonFlyUp= GetComponent<Animator>();
    }

    private void Update() {
        if (Input.GetMouseButton(0) || Input.GetKeyDown(KeyCode.Space)) {
        flyUp();
        }

        //Gravity mechanism
        direction.y += gravity * Time.deltaTime;
        transform.position += direction * Time.deltaTime;
    }

    private void flyUp() {
        pigeonFlyUp.Play("jumpMechanic", -1, 0f);
        direction = Vector3.up * strength;
    }
}
