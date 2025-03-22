using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipal : MonoBehaviour
{
    [SerializeField] private string gameNameLevel;
    [SerializeField] private GameObject MenuInicial;
    [SerializeField] private GameObject Opcoes;
    [SerializeField] private GameObject Creditos;
    public static bool MenuCreditos = false;

    public void Play()
    {
        SceneManager.LoadScene("Interface");
    }

    public void Options()
    {
        MenuInicial.SetActive(false);
        Opcoes.SetActive(true);
    }

    public void CloseOprions()
    {
        Opcoes.SetActive(false);
        MenuInicial.SetActive(true);
    }

    public void LeaveGame()
    {
        Application.Quit();
    }
    public void OpenCreditos()
    {
        MenuInicial.SetActive(false);
        Creditos.SetActive(true);
    }
    public void CloseCreditos()
    {
        Creditos.SetActive(false);
        MenuInicial.SetActive(true);
    }

}