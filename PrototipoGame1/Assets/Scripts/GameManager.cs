using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
    public static GameManager instance;
    public Transform canhao;
    public GameObject ball;
    public GameObject posBall;

    public int quantBallEmCena = 0;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
            CreateBall();
        } 
        else
        {
            Destroy(this);
        }

        
    }

    private void Update()
    {
        if(GameManager.instance.quantBallEmCena == 0)
        {
            CreateBall();
        }
    }

    private void CreateBall()
    {
        quantBallEmCena++;
        if(quantBallEmCena == 1)
        {
            Instantiate(ball, posBall.transform.position, Quaternion.identity, canhao);
        }

    }
}
