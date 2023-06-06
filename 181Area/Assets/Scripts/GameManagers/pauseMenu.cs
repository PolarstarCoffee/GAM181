using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pauseMenu : MonoBehaviour
{
    GameObject[] pauseUI; //Array for storing pause UI objects
    public static bool isGamePaused;
   
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            isGamePaused = !isGamePaused;
            pauseGame();
        }
        if (Input.GetKeyDown(KeyCode.Return)) 
        { 
            resumeGame();
        
        }
      
        
    }
    private void Start()
    {
        pauseUI = GameObject.FindGameObjectsWithTag("showOnPause");
        hidePause();
    }
    public void pauseGame() //freezes Unity time scale and "pauses" the application *NOTE UPDATE() FUNCTIONS STILL RUN
    {
        Time.timeScale = 0;
        AudioListener.pause = true;
        showPause();
    }

    public void resumeGame() //returns Unity timescale to 1 and "unpauses" the application
    {
        Time.timeScale = 1;
        AudioListener.pause = false;
        hidePause();
    }

    public void hidePause()
    {
        foreach(GameObject go in pauseUI) 
        { 
            go.SetActive(false);
        
        }
    }

    public void showPause()
    {
        foreach (GameObject go in pauseUI)
        {
            go.SetActive(true);

        }
    }

}
