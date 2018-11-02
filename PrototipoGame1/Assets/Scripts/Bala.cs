using System.Collections;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class Bala: MonoBehaviour
{
    private Rigidbody2D rigBall;
    float force = 5f;
    [SerializeField]
    private GameObject anguloCanhao;
    [SerializeField]
    private GameObject btnDisparar;
    private Animator animator;
    float x;
    float y;

    private void Start()
    {
        rigBall = GetComponent<Rigidbody2D>();
        anguloCanhao = GameObject.Find("Canhao");
        btnDisparar = GameObject.Find("BtnDisparar");
        btnDisparar.GetComponent<Button>().onClick.AddListener(Dispara);
        
    }

    private void Update()
    {

    }

    public void Dispara()
    {
        Vector2 dirForce;
        gameObject.GetComponent<Rigidbody2D>().isKinematic = false;
        x = force * Mathf.Cos(Mathf.Deg2Rad * (anguloCanhao.transform.eulerAngles.z - 270));
        y = force * Mathf.Sin(Mathf.Deg2Rad * (anguloCanhao.transform.eulerAngles.z - 270));
        dirForce = new Vector2(x,y);
        gameObject.transform.SetParent(null);
        rigBall.AddForce(dirForce, ForceMode2D.Impulse);
        
        Vector2 vector = new Vector2(x, y);
        Debug.DrawLine(transform.position, vector, Color.white, 10f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("obstaculo"))
        {
            gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0,0);
            gameObject.GetComponent<Rigidbody2D>().angularVelocity = 0f;
            gameObject.GetComponent<Rigidbody2D>().isKinematic = true;
            gameObject.transform.SetParent(collision.gameObject.transform.parent);
            GameManager.instance.canhao = collision.gameObject.transform.parent;
            GameManager.instance.posBall = collision.gameObject.transform.parent.GetChild(0).gameObject;
            anguloCanhao = collision.gameObject.transform.parent.gameObject;
            animator = anguloCanhao.GetComponent<Animator>();
            if((collision.gameObject.transform.parent.gameObject.name == "Canhao (3)"))
            {
                CameraSeguePersonagem camSeg = Camera.main.gameObject.GetComponent<CameraSeguePersonagem>();
                camSeg.moveCamera = true;
                camSeg.lastTime = Time.time;
            }
        }
    }


}
