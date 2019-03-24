using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ui : MonoBehaviour {
    public void OnClickStart()
    {
        SceneManager.LoadScene(1);
    }
     public void OnClickExit()
    {
        Application.Quit();
    }
    public void Escp()
    {
        SceneManager.LoadScene(0);
    }

}
