using UnityEngine;
using UnityEngine.SceneManagement;

public class Court : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Ball ball = collision.gameObject.GetComponent<Ball>();

        if (ball == null) return;

        SceneManager.LoadScene("gameOver");
    }
}