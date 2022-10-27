using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreMechanic : MonoBehaviour {
    public TextMesh Score;
    private int scoreNumber;

    void Start() {
        Score = GetComponent<TextMesh> ();
        scoreNumber = 0;
        
    }

    void Update() {
        Score.GetComponent<TextMesh>().text = "Score - " + scoreNumber;
    }
}
