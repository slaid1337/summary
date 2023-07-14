using UnityEngine;
using UnityEngine.SceneManagement;

public class Point : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        CircleMove circleMover = null;

        if (collision.transform.TryGetComponent<CircleMove>(out circleMover))
        {
            PointCounter.Instance.AddPoint();
            Destroy(transform.parent.gameObject);
        }
    }
}
