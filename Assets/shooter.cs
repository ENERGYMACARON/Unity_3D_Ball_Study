// using System.Threading.Tasks.Dataflow;
using UnityEngine;

public class shooter : Obstacle
{
    public GameObject stone;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    float timeCount = 0;
    // Update is called once per frame
    void Update()
    {
        base.Update();
        timeCount += Time.deltaTime;
        if(timeCount > 10)
        {
            Instantiate(stone, transform.position, Quaternion.identity);
            timeCount = 0;
        }
        
    }
}
