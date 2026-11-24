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
    [SerializeField] private Scenes targetScene;
    public void ChangeScene()
    {
        SceneManager.LoadScene(targetScene.ToString());
    }
}
