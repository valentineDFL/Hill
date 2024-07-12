using UnityEngine;

public class EndGame : MonoBehaviour
{
    [SerializeField] private GameObject _endGamePanel;
    [SerializeField] private GameObject _mainGamePanel;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameOver();
    }

    public void GameOver()
    {
        _mainGamePanel.SetActive(false);
        _endGamePanel.SetActive(true);
        Time.timeScale = 0;
    }
}
