public class Pontuacao: Behavior
{
  private int pontos = 0;
  private Text text;
  
  private void Start()
  {
    text = GameObject.Find("pontos");
  }
  
  private void OntriggerEnter2D(Collision outro)
  {
    if(outro.gameObject.Comparetag("player"))
    {
      pontos++;
      text.Text = pontos.String();
    }
  }
}
