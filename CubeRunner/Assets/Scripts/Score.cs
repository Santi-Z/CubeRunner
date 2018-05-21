using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform player;
    public Text scoreText;

    string Progress()
    {
        float distance = player.position.z;
        float progress = distance / 3;
        string percentage = progress.ToString("0");
        return percentage;
    }
    void Update()
    {
        string percentage = Progress();
        scoreText.text = percentage + "%";
    }
}
