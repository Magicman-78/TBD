using System;
using System.Collections;
using TMPro;
using UnityEngine;

public class FakeClock : MonoBehaviour
{
    [SerializeField] private int startingTime;
    [SerializeField] private float timeUntilHourChange;
    [SerializeField] private TMP_Text timeText;
    [SerializeField] private int timeLimit;

    [NonSerialized] public int timeHours;

    void Start()
    {
        // Sets timeHours equal to whatever the startingTime int is
        timeHours = startingTime;
        // Starts the coroutine so that the time starts
        StartCoroutine(advanceHourOverTime());
    }

    void Update()
    {
        // Sets the time text to say whatever timeHours is equal to along with :00 PM
        timeText.text = timeHours + ":00 PM";

        // If timeHours equals 12, then it makes the text display 12 along with :00 AM instead of :00 PM
        if (timeHours == 12)
        {
            timeText.text = timeHours + ":00 AM";
        }
    }

    // This coroutine makes everything function by waiting for whatever timeUntilHourChange is equal to, and then checking if it is equal to 12, and if it isn't, then it adds 1 to timeHours until it reaches whatever timeLimit is equal to
    private IEnumerator advanceHourOverTime()
    {
        yield return new WaitForSeconds(timeUntilHourChange);

        // Checks if timeHours equals 12, and if it does, then it changes the text to say ":00 AM", and if it doesn't, then it adds 1 to timeHours
        if (timeHours == 12)
            timeText.text = timeHours + ":00 AM";
        else
            timeHours++;
        // Checks if timeHours is less than timeLimit, and if it is, then the coroutine begins again, if it's not, the coroutine stops
        if (timeHours < timeLimit)
            StartCoroutine(advanceHourOverTime());
    }
}
