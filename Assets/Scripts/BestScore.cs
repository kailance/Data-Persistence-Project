using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BestScore : MonoBehaviour
{
    private string bestName;
    private int bestScore;
    private void Start()
    {
        bestName = DataManager.Instance.topName;
        bestScore = DataManager.Instance.topScore;
        GameObject.Find("BestScore").GetComponent<TextMeshProUGUI>().text = "Best Score: " + bestName + ": " + bestScore;
    }
}
