using UnityEngine;

public class LogicalOperator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int age = 30;
        if(age < 20 || age > 65)
        {
            Debug.Log("할인 대상입니다.");
        }

        if(age >= 30 && age <= 39)
        {
            Debug.Log("30대 입니다.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
