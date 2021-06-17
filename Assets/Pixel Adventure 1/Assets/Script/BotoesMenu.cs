using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class BotoesMenu : MonoBehaviour
{

    public string nomeCena;
   
    public void carregarCena()
    {
        
                SceneManager.LoadScene(nomeCena);
            
    }

    public void sair()
    {
        Application.Quit();
    } 
}
