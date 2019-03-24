using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pause : MonoBehaviour {

    private Mousecontrol mousecontrol;
    public GameObject pausecanvas;
    public float timing;
    public bool ispause;

    private void Start()
    {
        mousecontrol = GetComponent<Mousecontrol>();
    }
    private void Update () {
        Time.timeScale = timing;
        if (Input.GetKeyDown(KeyCode.Escape) && ispause == false)
        {
            ispause = true;
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && ispause == true)
        {
            ispause = false;
        }
        if (ispause == true)
        {
            timing = 0;
            pausecanvas.SetActive(true);
            mousecontrol.enabled = false;

        }
        else if (ispause == false)
        {
            timing = 1;
            pausecanvas.SetActive(false);
            mousecontrol.enabled = true;
        }
    }

    public void Resume(bool state)
    {
        ispause = state;
    }
}
