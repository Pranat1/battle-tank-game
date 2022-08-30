using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI textScore;
    int score;
    void Start(){
        ServiceEvents.Instance.OnFire += IncreaseScore;
        score = 0;
    }

    public void IncreaseScore(){
        score += 1;
        textScore.text = score.ToString();
    }
}
