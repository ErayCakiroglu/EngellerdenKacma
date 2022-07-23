using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class YenidenOyna : MonoBehaviour
{
    public void yenidenOyna()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Can.kalanCan = 5;
        Time.timeScale = 1;
    }
}
