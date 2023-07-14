using System.Collections;
using UnityEngine;

public class LevelGenirator : MonoBehaviour
{
    [SerializeField] private GameObject _borderPref;
    [SerializeField] private Transform _camera;

    [SerializeField] private Transform _topTransform;
    [SerializeField] private Transform _bottomTransform;

    [SerializeField] private GameObject _boxPref;

    [SerializeField] private GameObject _pointPref;

    private float _topY;
    private float _bottomY;

    private void Start()
    {
        _topY = _topTransform.position.y;
        _bottomY = _bottomTransform.position.y;

        StartCoroutine(CreateBordersCor());
        StartCoroutine(CreateBoxCor(1f));
        StartCoroutine(CreatePointCor());
    }

    private IEnumerator CreateBoxCor(float delay)
    {
        yield return new WaitForSeconds(delay);
        BoxMover boxMover = Instantiate(_boxPref, new Vector3(_camera.position.x + 20f, 0, 0), Quaternion.identity).GetComponent<BoxMover>();
        boxMover.topPositionY = _topY;
        boxMover.bottomPositionY = _bottomY;

        StartCoroutine(CreateBoxCor(2f));
    }

    private IEnumerator CreateBordersCor()
    {
        yield return new WaitForSeconds(4f);

        Instantiate(_borderPref, new Vector3( _camera.position.x, _topY, 0), Quaternion.identity);
        Instantiate(_borderPref, new Vector3(_camera.position.x, _bottomY, 0), Quaternion.identity);

        StartCoroutine(CreateBordersCor());
    }

    private IEnumerator CreatePointCor()
    {
        yield return new WaitForSeconds(3f);

        Instantiate(_pointPref, new Vector3(_camera.position.x + 20f, Random.Range(_topY - 7, _bottomY + 7), 0), Quaternion.identity);

        StartCoroutine(CreatePointCor());
    }
}
