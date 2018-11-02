using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canhao : MonoBehaviour {

    public Transform alvo;

	// Use this for initialization
	void Start () {
        Debug.DrawLine(transform.position, alvo.position, Color.white, 10f);
    }
	
	// Update is called once per frame
	void Update () {
        //Time.timeScale = 0.01f;
	}
}
