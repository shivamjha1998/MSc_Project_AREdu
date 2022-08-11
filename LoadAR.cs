using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadAR : MonoBehaviour
{
    public void Loading() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Exit(){
        Application.Quit();
    }

    public void MainMenu(){
        SceneManager.LoadScene(0);
    }
}
