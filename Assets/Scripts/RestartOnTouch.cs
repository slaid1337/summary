using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartOnTouch : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        CircleMove circleMover = null;

        if (collision.transform.TryGetComponent<CircleMove>(out circleMover))
        {
            SceneManager.LoadScene(0);
        }
    }
}
