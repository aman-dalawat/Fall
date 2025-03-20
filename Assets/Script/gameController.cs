using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameController : MonoBehaviour
{

    public GameObject exitMenu;
    public GameObject pauseButton;
    // Start is called before the first frame update
    void Start()
    {
        exitMenu.SetActive(false);
        pauseButton.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ExitGame()
    {
        exitMenu.SetActive(true);
        pauseButton.SetActive(false);
    }

    public void ResumeGame()
    {
         exitMenu.SetActive(false);
        pauseButton.SetActive(true);
    }

    public void QuitGame()
    {
       Application.Quit();
    }
}
