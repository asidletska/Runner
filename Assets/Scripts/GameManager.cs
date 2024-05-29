using UnityEngine;
using TMPro;


public class GameManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI coinText;
    public Player player;
    public GameObject panel;
    private int _coinsCount;

    public void Play()
    {
        Restart();

    }
    public void Pause()
    {
        Time.timeScale = 0f;
        player.enabled = false;
    }
    public void GameOver()
    {
        panel.SetActive(true);

        Pause();
    }

    public void Restart()
    {
        player.enabled = true;
    }

    public void AddCoin()
    {
        _coinsCount++;
        coinText.text = _coinsCount.ToString();
    }
}
