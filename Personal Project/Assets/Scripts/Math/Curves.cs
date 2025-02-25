using UnityEngine;

public class Curves : MonoBehaviour
{
    public float width, height, xOffset, yOffset;

    void Update()
    {
        float t = Time.time;

        // Multiply inside of sine/cosine to modify speed
        // Multiply outside of sine/cosine to modify size
        // Add outside of sine/cosine to modify offset

        float x = width * Mathf.Cos(t) + xOffset;
        float y = height * Mathf.Sin(t) + yOffset;

        transform.position = new(x, y);
    }
}
