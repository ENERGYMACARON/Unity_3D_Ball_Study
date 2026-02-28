using UnityEngine;

public class stone : MonoBehaviour
{
    Vector3 target;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        target = GameObject.Find("Ball").transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target, 0.1f);
        transform.Rotate(new Vector3(0,0,5));
    }

    void OnTriggerEnter(Collider collider)
    {
        // Debug.Log(collider.gameObject.name);
        if(collider.gameObject.name == "Ball")
        {
            GameObject.Find("GameManager").SendMessage("RestartGame");
            
            // GameObject gm = GameObject.Find("GameManager");
            // GameManager gmComponent = gm.GetComponent<GameManager>;
            // GameManager gmComponent = GameObject.Find("GameManager").GetComponent<GameManager>();
            // gmComponent.RestartGame();

        }
    }
}
