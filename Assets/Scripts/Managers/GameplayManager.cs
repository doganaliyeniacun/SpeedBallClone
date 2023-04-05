using TMPro;
using UnityEngine;

public class GameplayManager : MonoBehaviour
{
    public static GameplayManager instance;

    [SerializeField] private GameObject gameOverUI;
    [SerializeField] private GameObject youWinUI;
    [SerializeField] private GameObject ballPrefab;
    [SerializeField] private Transform startPos;
    [SerializeField] private TextMeshProUGUI scoreText;

    [Header("Setting")]
    [SerializeField] private float scoreRate = 2f;

    public static string playerName = "Player";

    private float score = 0;

    private void Start()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void StartGame()
    {
        gameOverUI.SetActive(false);
        youWinUI.SetActive(false);
        ballPrefab.transform.position = startPos.position;
        Time.timeScale = 1f;
    }

    public void GameOver()
    {
        gameOverUI.SetActive(true);
        Time.timeScale = 0f;
    }

    public void YouWin()
    {
        youWinUI.SetActive(true);
        Time.timeScale = 0f;
    }

    private string GetScore() => "Score : " + score;

    public void IncrementScore()
    {
        score++;
        scoreText.text = GetScore();
        scoreText.color = Random.ColorHSV();
    }
}
