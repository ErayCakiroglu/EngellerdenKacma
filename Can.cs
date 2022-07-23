using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Can : MonoBehaviour
{
    public static int kalanCan = 5;
    [SerializeField] TextMeshProUGUI canYazisi;
    [SerializeField] GameObject bitisPaneli;
    void Update()
    {
        canYazisi.text = "Can : " + kalanCan.ToString();

        if(kalanCan == 0)
        {
            bitisPaneli.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
