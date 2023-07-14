using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform _target;
    [SerializeField] private Vector3 _offset;

    private void Start()
    {
        _offset = transform.position - _target.position;
    }

    private void Update()
    {
        Vector3 newPosition = _target.position + _offset;
        newPosition.y = _offset.y;

        transform.position = newPosition;
    }
}
