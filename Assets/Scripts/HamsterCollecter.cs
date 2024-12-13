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
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateCount()
    {
        hamsterDisplay.text = $"Hamster's Collected: {numberOfHamsters}";
    }
}
