using UnityEngine;

public class CircleMove : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _force;
    private Rigidbody2D _rigidBody;

    private void Start()
    {
        _rigidBody = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        _rigidBody.velocity = new Vector2(1 * _speed, _rigidBody.velocity.y);

        if (Input.GetMouseButton(0) || Input.GetKey(KeyCode.Space))
        {
            _rigidBody.AddForce(Vector2.up * _force, ForceMode2D.Force);
        }
    }
}
