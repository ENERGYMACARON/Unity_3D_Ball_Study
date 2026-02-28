using UnityEngine;
using System.Collections;

public class Coin : MonoBehaviour
{
    void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.name == "Ball")
        {
            GameObject.Find("GameManager").SendMessage("GetCoin");
            Destroy(gameObject);
        }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
