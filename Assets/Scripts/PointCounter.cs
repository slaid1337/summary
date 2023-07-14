using UnityEngine;
using UnityEngine.Events;

public class PointCounter : MonoBehaviour
{
    private static PointCounter m_instance;
    private int _pointsCount;

    public UnityEvent<int> OnAddPoint;

    public static PointCounter Instance
    {
        get
        {
            if (m_instance == null)
            {
                m_instance = GameObject.FindObjectOfType<PointCounter>();

                if (m_instance == null)
                {
                    GameObject singleton = new GameObject(typeof(PointCounter).Name);
                    m_instance = singleton.AddComponent<PointCounter>();
                }
            }
            return m_instance;
        }
    }

    private void Awake()
    {
        if (m_instance == null)
        {
            m_instance = this as PointCounter;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void AddPoint()
    {
        _pointsCount++;

        OnAddPoint.Invoke(_pointsCount);
    }
}
