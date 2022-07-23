using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Engeller : MonoBehaviour
{
    static int skor;
    [SerializeField] TextMeshProUGUI skorYazisi, bitisYazisi;

    void Start()
    {
        skor = 0;
    }

    void Update()
    {
        skorYazisi.text = skor.ToString();
        bitisYazisi.text = "Oyun Bitti ! \n Skor : " + skor.ToString();
    }
    void OnCollisionEnter2D(Collision2D temas)
    {
        float xPozisyonu = Random.Range(-9f, 10f);
        float yPozisyonu = Random.Range(6.5f, 16f);
        if(temas.gameObject.tag == "KontrolCubugu")
        {
            transform.position = new Vector2(xPozisyonu, yPozisyonu);
            skor += Random.Range(8, 11);
        }

        if(temas.gameObject.tag == "Karakter")
        {
            transform.position = new Vector2(xPozisyonu, yPozisyonu);
            Can.kalanCan -= 1;
        }
    }
}
