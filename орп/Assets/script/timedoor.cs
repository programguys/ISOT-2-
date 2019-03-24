using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class timedoor : MonoBehaviour {
    public float t;
    public GameObject Obj;
    public float timerdoor;
    public GameObject Sd;
    public GameObject Do;
    

    public Text timerText;
    private float startTime;
	
	void Start () {
        startTime = 0f;
	}
	
	
	void Update () {

        
        float t = Time.time - startTime;

        string minutes = ((int) t / 60).ToString();
        string seconds = (t % 60).ToString("f2");
        timerText.text = minutes + ":" + seconds;

        if (timerdoor > 0)
        {
            timerdoor -= Time.deltaTime;
        }

        if (timerdoor <= 0)
        {
            Obj.SetActive(true);
            Do.SetActive(true);
            Sd.SetActive(false);
        }
        
       
  
    }
    
}
