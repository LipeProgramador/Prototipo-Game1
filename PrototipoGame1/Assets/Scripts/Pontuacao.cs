using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Pontuacao: MonoBehaviour
{
  private int pontos = 0;
  private Text text;
  
  private void Start()
  {
        text = GameObject.Find("Pontos").gameObject.GetComponent<Text>() ;
  }
  
  private void OntriggerEnter2D(Collision outro)
  {
    if(outro.gameObject.CompareTag("player"))
    {
      pontos++;
      text.text = pontos.ToString();
    }
  }
}
