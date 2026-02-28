using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    int coinCount = 0;
    public TMP_Text coinScore;
    void GetCoin()
    {
        coinCount++;
        coinScore.text = "Get Coin: " + coinCount;
    }
    void RestartGame()
    {
        Debug.Log("씬 재시작 시도 중...");
            // 0번 인덱스(보통 첫 번째 씬)를 강제로 로드
            SceneManager.LoadScene(0); 
            
            // 만약 시간이 멈춰있을 경우를 대비해 시간 재생
            Time.timeScale = 1f;
    }

    void RedCoinStart()
    {
        DestroyObstacles();
    }

    void DestroyObstacles()
    {
        GameObject[] obstacles = GameObject.FindGameObjectsWithTag("Obstacle");
        for(int i=0; i<obstacles.Length; i++)
        {
            Destroy(obstacles[i]);
        }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        coinScore.text = "Get Coin: ";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
