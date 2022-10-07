using UnityEngine;
using UnityEngine.SceneManagement;
public class Reload : MonoBehaviour
{
    /// <summary>
    /// перезапуск сцены с игрой
    /// </summary>
    public void ReloadGame()
    {
        SceneManager.LoadScene(0);
    }
}
