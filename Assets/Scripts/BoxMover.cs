using UnityEngine;

public class BoxMover : MonoBehaviour
{
    public float topPositionY;
    public float bottomPositionY;
    private bool _isUp;

    private void Start()
    {
        float randomValue = Random.Range(0, 100);

        if (randomValue < 50)
        {
            _isUp = true;
        }
        else
        {
            _isUp = false;
        }
    }

    private void Update()
    {
        if( _isUp )
        {
            transform.Translate(0, 0.01f, 0);
        }
        else
        {
            transform.Translate(0, -0.01f, 0);
        }
        
        if (transform.position.y >= topPositionY - 3f || transform.position.y <= bottomPositionY + 3f)
        {
            _isUp = !_isUp;
        }
    }
}
