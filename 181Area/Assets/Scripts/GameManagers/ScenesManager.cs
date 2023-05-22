using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesManager : MonoBehaviour
{
    //static class makes it so this method is accessible in any way within any function. 
    public static ScenesManager instance;
    public Animator transition; //animator ref
    public float transitionTime = 1f;
    private void Awake()
    {
        instance = this;
    }

    public enum Scene //Levels are by index (mainMenu = 0, Level01 = 1, etc.. NOTE: MAKE SURE ENUM ENTRIES MATCH ORDER WITHIN UNITY'S BUILD SETTINGS, OR GAME WILL BLOW UP 
    {
        Untitled_Shooter1,
        safeZone
    }

    // Load Scene method
    public void LoadScene(Scene scene)
    {
        SceneManager.LoadScene(scene.ToString()); //scene enum needs to be converted to string to be readable by method
    }

    //load new game method
    public void LoadNewGame()
    {
        SceneManager.LoadScene(Scene.Untitled_Shooter1.ToString());
    }


    //Load next scene method (Does so by increasing index of Unity build index by 1)
    public void LoadNextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }


    //Load previous scene method (scene index reduction)
    public void LoadLastScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }


    public void Quit()
    {
        Application.Quit();
    }

}