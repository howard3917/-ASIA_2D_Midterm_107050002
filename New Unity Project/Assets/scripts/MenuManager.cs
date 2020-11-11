using UnityEngine.SceneManagement;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    public void Startgame()
    {
        print("開始遊戲");
        SceneManager.LoadScene("場景");
    }
    public void Quitgame()
    {
        print("結束遊戲");
        Application.Quit();
    }

}
