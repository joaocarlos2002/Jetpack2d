using UnityEngine;

public class points : MonoBehaviour
{
    public GameController controller;

    void Start()
    {
        controller = Object.FindFirstObjectByType<GameController>();
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        controller.score++;
        controller.scoreText.text = controller.score.ToString();
    }
}
