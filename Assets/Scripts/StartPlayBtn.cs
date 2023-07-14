using UnityEngine;
using UnityEngine.UI;

public class StartPlayBtn : MonoBehaviour
{
    private Button _btn;

    private void Start()
    {
        _btn = GetComponent<Button>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _btn.onClick.Invoke();
        }
    }
}
