using UnityEngine;
using System.Collections;
using Unity.VisualScripting;

public class StressMeter : MonoBehaviour
{
    public float currentStress, maxStress, stressRate;

    void Start()
    {
        StartCoroutine(FillStress());
    }


    void Update()
    {
        
    }

    private IEnumerator FillStress()
    {
        while(currentStress < maxStress)
        {
            currentStress += stressRate / 100f;

            if (currentStress >= maxStress)
                currentStress = maxStress;

            yield return new WaitForSeconds(.01f);
        }
    }
}
