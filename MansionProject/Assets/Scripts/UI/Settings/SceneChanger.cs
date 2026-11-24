using NUnit.Framework;
using UnityEngine;
using UnityEngine.SceneManagement;
public enum Scenes
{
    MainMenuScene,
    GameScene,
}
public class SceneChanger : MonoBehaviour
{
    [Header("Scene you wanna change to")]
    [SerializeField] private Scenes targetScene;
    public void ChangeScene()
    {
        SceneManager.LoadScene(targetScene.ToString());
    } 

    public void ExitGame()
    {
        Application.Quit();
    }
}
