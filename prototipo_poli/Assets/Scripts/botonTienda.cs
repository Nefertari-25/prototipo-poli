using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class botonTiendaa : MonoBehaviour
{
    [SerializeField] private GameObject botonTienda;
    [SerializeField] private GameObject menuTienda;
    private bool juegoPausado = false;

    public void pausa()
    {
        juegoPausado = true;
        Time.timeScale = 0f;
        botonTienda.SetActive(false);
        menuTienda.SetActive(true);
    }

    public void reanudar()
    {
        juegoPausado = false;
        Time.timeScale = 1f;
        botonTienda.SetActive(true);
        menuTienda.SetActive(false);
    }

    public void jugar()
    {
        menuTienda.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
