using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JogoLvl1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    // Abre a cena MenuInicial quando apertarmos o botão Voltar ao menu inicial
    public void voltaMenuInicial()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("MenuInicial");
    }
}
