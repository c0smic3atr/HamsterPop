using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HamsterCollecter : MonoBehaviour
{
    public TextMeshProUGUI hamsterDisplay;
    public int numberOfHamsters;

    // Start is called before the first frame update
    void Start()
    {
        UpdateCount();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateCount()
    {
        StartCoroutine(DelayedCount());
    }

    public IEnumerator DelayedCount()
    {
        yield return new WaitForEndOfFrame();

        numberOfHamsters = GameObject.FindGameObjectsWithTag("Hamster").Length;
        hamsterDisplay.text = $"Hamster's Left: {numberOfHamsters}";
    }
    

}