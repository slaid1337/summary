using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttractToObject : MonoBehaviour
{
    private Transform _target;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        CircleMove circleMover = null;

        if (collision.transform.TryGetComponent<CircleMove>(out circleMover))
        {
            _target = collision.transform;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        CircleMove circleMover = null;

        if (collision.transform.TryGetComponent<CircleMove>(out circleMover))
        {
            _target = null;
        }
    }

    private void Update()
    {
        if (_target != null)
        {
            transform.Translate((_target.position - transform.position).normalized / 30f);
        }
    }
}
