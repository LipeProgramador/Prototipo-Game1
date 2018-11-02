using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSeguePersonagem : MonoBehaviour {
    public bool moveCamera = false;
    private float time = 0;
    public float lastTime = 0;
    public float currentTime = 0;
    public float distance;
    public float timeSpent;
    public float distanceSpent;
    private float speed = 16f;
    public float displacement;
    public Vector3 startPositionCamera;
	// Use this for initialization
	void Start () {
        distance = Vector3.Distance(transform.position, new Vector3(16f, 0, -10));
        startPositionCamera = transform.position;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        if (moveCamera)
        {
            currentTime = Time.time;
            timeSpent = currentTime - lastTime;
            distanceSpent = timeSpent * speed;
            displacement = distanceSpent / distance;
            print(Time.time);
            transform.position = Vector3.Lerp(startPositionCamera, new Vector3(16f, 0, -10), displacement);
            if(displacement >= 1)
            {
                moveCamera = false;
            }
        }
	}
}
