public class Teste: Behavior
{
  private Rigidbody2D rigBall;
  private void Start()
  {
    rigBall = GetComponent<Rigidbody2D>();
  }
  public void Dispara()
  {
    float x;
    float y;
    Vector2 dirForce;
    x = force * Mathf.Cos(Mathf.Deg2Rad(transform.eulerAngle));
    y = force * Mathf.Cos(Mathf.Deg2Rad(transform.eulerAngle));
    dirForce = new Vector2(x,y);
    rigBall.addForce(dirForce);
  }
}
