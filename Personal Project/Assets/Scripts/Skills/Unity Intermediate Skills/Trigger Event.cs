using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class TriggerEvent : MonoBehaviour
{
    // UnityEvents allow you to create generic scripts instead of repeating yourself across multiple script.
    public UnityEvent onTriggerEnter;

    private void OnTriggerEnter2D(Collision2D collision)
    {
        // Runs each of the functions assigned in the inspector
        onTriggerEnter.Invoke();
    }

    // For a function to be compatible with UnityEvents, it must be public, a void, and take a simple variable type
    // By simple, I mean string, int, bool, or float. It can't be a Vector or a Matrix or anything complex like that
    public void SwitchScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
