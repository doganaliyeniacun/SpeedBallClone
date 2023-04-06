using TMPro;
using UnityEngine;

public class GameplayManager : MonoBehaviour
{
    public static GameplayManager instance;

    [SerializeField] private GameObject gameOverUI;
    [SerializeField] private GameObject youWinUI;
    [SerializeField] private Transform startPos;
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private GameObject ballPrefab;


    [Header("[Setting]")]
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
        Time.timeScale = 1f;
        resetBall();
        ballPrefab.transform.position = startPos.position;
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

    private void resetBall() => ballPrefab.GetComponent<BallMovement>().ResetSetting();
}
