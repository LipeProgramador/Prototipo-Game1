public class Pontuacao: Behavior
{
  int pontos = 0;
  private void OntriggerEnter2D(Collision outro)
  {
    if(outro.gameObject.Comparetag("player"))
    {
      pontos++;
    }
  }
}
