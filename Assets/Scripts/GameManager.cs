using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] private int nCoin;
    private int takeCoin;
    public Text coinPoints;

    private void Start()
    {
        takeCoin = 0;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Gold")
        {
            Destroy(collision.gameObject, 0.2f);
            takeCoin++;
            coinPoints.text = takeCoin.ToString();
            if(takeCoin==nCoin)  // если число взятых монет равно числу монет на карте выводится экран победы
            {
                SceneManager.LoadScene(1);
            }
            
        }
        if (collision.tag == "Death")
        {
            Destroy(gameObject, 0.2f);
            SceneManager.LoadScene(2);
        }
    }
}
