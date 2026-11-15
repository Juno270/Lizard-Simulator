using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitchScript : MonoBehaviour
{
    public GameObject PlayButton;
    public GameObject QuitButton;
    public GameObject Level1Button;
    public GameObject Level2Button;
    public GameObject BackButton;
    public GameObject Level3Button;

    void Start()
    {
        Level1Button.SetActive(false);
        Level2Button.SetActive(false);
        BackButton.SetActive(false);
        Level3Button.SetActive(false);
    }

    public void Switch()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void Levelselect()
    {
        PlayButton.SetActive(false);
        QuitButton.SetActive(false);
        Level1Button.SetActive(true);
        Level2Button.SetActive(true);
        Level3Button.SetActive(true);
        BackButton.SetActive(true);
    }

    public void BackToMenu()
    {
        PlayButton.SetActive(true);
        QuitButton.SetActive(true);
        Level1Button.SetActive(false);
        Level2Button.SetActive(false);
        Level3Button.SetActive(false);
        BackButton.SetActive(false);
    }

    public void Level1()
    {
        SceneManager.LoadScene("DAY");
    }

    public void Level2()
    {
        SceneManager.LoadScene("NIGHT");
    }

    public void Level3()
    {
        SceneManager.LoadScene("DESERT");
    }
}
