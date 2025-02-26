using TMPro;
using UnityEngine;

public class FakeClock : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    public float timeUntilMinute;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeUntilMinute += Time.deltaTime;
       
    }
}
