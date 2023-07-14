using UnityEngine;
using UnityEngine.UI;

public class PointText : MonoBehaviour
{
    private Text _text;

    private void Start()
    {
        PointCounter.Instance.OnAddPoint.AddListener(RefreshText);
        _text = GetComponent<Text>();
    }

    private void RefreshText(int value)
    {
        _text.text = value.ToString();
    }
}
