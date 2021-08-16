using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseControl : MonoBehaviour
{

    public GameObject PauseMenuUI;
    public GameObject Control;
    private bool isPaused = false;
    private bool controlBool = false;


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {

            isPaused = !isPaused;
            //sesler kapat

        }
        if (isPaused)
        {
            ActivateMenu();
        }
        else
        {
            DeactivateMenu();
        }

    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }
    
    public void Exit()
    {
        Application.Quit();
    }

    public void Controls()
    {
        if(controlBool)
        {
            Control.SetActive(true);
        }
        else
        {
            Control.SetActive(false);
        } 
        controlBool = !controlBool;
    }

    public void Retry()
    {
        SceneManager.LoadScene("test0");
    }

    public void ActivateMenu()
    {
        Time.timeScale = 0;
        transform.GetComponent<Movement>().enabled = false;
        transform.Find("Sounds").gameObject.SetActive(false);
        PauseMenuUI.SetActive(true);
    }

    public void DeactivateMenu()
    {
        Time.timeScale = 1;
        transform.GetComponent<Movement>().enabled = true;
        transform.Find("Sounds").gameObject.SetActive(true);
        PauseMenuUI.SetActive(false);
        isPaused = false;
    }

}
