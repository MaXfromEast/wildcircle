using UnityEngine;
using UnityEngine.SceneManagement;
public class Reload : MonoBehaviour
{
    /// <summary>
    /// ���������� ����� � �����
    /// </summary>
    public void ReloadGame()
    {
        SceneManager.LoadScene(0);
    }
}
