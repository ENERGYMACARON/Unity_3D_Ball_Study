using UnityEngine;

public class CamaraWork : MonoBehaviour
{
    GameObject ball;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ball = GameObject.Find("Ball");
        GameObject[] coins = GameObject.FindGameObjectsWithTag("Coin");
        for(int i=0; i<coins.Length; i++)
        {
            Debug.Log(coins[i].name);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log("저는 카메라 인데, 볼의 위치는 " + ball.transform.position.z);
        transform.position = new Vector3(0, ball.transform.position.y + 3, ball.transform.position.z - 14);
        
    }
}
