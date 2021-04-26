using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinScreenScript : MonoBehaviour
{
    public void Nextlvl()
    {
        if(SceneManager.GetActiveScene().buildIndex != 11)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
        }
        else
        {
            SceneManager.LoadScene(0);
        }
    }
    public void LevelSelection()
    {
        SceneManager.LoadScene(1);
    }
}
