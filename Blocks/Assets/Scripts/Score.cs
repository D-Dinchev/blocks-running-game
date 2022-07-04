using System;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform Player;
    public Text scoreText;
    void Update()
    {
        scoreText.text = Player.position.z.ToString("0");
    }
}
