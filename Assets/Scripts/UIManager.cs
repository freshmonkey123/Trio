using UnityEngine;
using UnityEngine.SceneManagement;


public class UIManager : MonoBehaviour
{
    [SerializeField] private GameObject panelLose;


    public void Lose()
    {
        panelLose.SetActive(true);
    }

    public void Play()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void URL()
    {
        Application.OpenURL("https://vk.com/nikita_na_meste");
    }
}
