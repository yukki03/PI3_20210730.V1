using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuInicial : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Abre a cena Loja quando apertarmos o botão Loja
    public void abreLoja() 
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Loja");
    }

    // Abre a cena Jogo quando apertarmos o botão Jogar
    public void abreJogo()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("");
    }

    // Fecha o build ao apertarmos o botão Sair
    public void fechaMenuInicial()
    {
        Application.Quit();
    }
}
