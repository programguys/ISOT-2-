using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;



public class Button : MonoBehaviour {
    public void OnclickExit()
    {
        SceneManager.LoadScene(0);
    }
    public void OnClickQuit()
    {
        Application.Quit();
    }
    
    

}
