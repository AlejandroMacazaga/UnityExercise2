using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class PauseMenuLogic : MonoBehaviour
{

    public GameObject pauseMenu;
    void Update()
    {
        // Using the input system, we can check if the escape key is pressed
        // If it is, we can call the PauseMenuStart method
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PauseMenuStart();
        }
        
    }
    // Start is called before the first frame update
    public void MainMenu()
    {
        SceneManager.LoadScene("MenuScene");
    }
    
    public void Resume() {
        Time.timeScale = 1;
        pauseMenu.SetActive(false);
        
    }

    private void PauseMenuStart()
    {
        Time.timeScale = 0;
        pauseMenu.SetActive(true);
    }
}
