using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private GameObject MainMenu;
    [SerializeField]
    private GameObject Stages;

    private void Awake()
    {
        MainMenu.SetActive(true);
        Stages.SetActive(false);
    }

    public void Play()
    {
        MainMenu.SetActive(false);
        Stages.SetActive(true);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void MainMenuButton()
    {
        MainMenu.SetActive(true);
        Stages.SetActive(false);
    }

    public void Stage_1_Button() 
    {
        SceneManager.LoadScene(1);
    }

    public void Stage_2_Button()
    {
        SceneManager.LoadScene(2);
    }

    public void Stage_3_Button()
    {
        SceneManager.LoadScene(3);
    }

}
