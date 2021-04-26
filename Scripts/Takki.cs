using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Takki : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey("space"))  // Ef að notandi ýtir á space byrjar leikurinn upp á nýtt
        {
            Byrjun();  // Kalla í klasa sem að loadar inn nýrri senu
        }
    }
    public void Byrjun()
    {
        SceneManager.LoadScene(1);
    }
}
