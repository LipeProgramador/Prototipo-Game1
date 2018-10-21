using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Teste: MonoBehaviour
{
    private Rigidbody2D rigBall;
    float force = 150f;
    public Transform anguloCanhao;

    private void Start()
    {
        rigBall = GetComponent<Rigidbody2D>();
    }
    public void Dispara()
    {
        float x;
        float y;
        Vector2 dirForce;
        x = force * Mathf.Cos(Mathf.Deg2Rad * anguloCanhao.transform.eulerAngles.z);
        y = force * Mathf.Cos(Mathf.Deg2Rad * anguloCanhao.transform.eulerAngles.z);
        dirForce = new Vector2(x,y);
        rigBall.AddForce(dirForce);
    }
}
