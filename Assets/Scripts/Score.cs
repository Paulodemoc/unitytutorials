using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text ScoreText;
    public Transform Player;

    // Update is called once per frame
    private void Update()
    {
        ScoreText.text = Player.position.z.ToString("0");
    }
}