using UnityEngine;
using UnityEngine.Events;

public class Button : MonoBehaviour
{

    public float minDistance;
    public bool _wasPressed;
    public UnityEvent OnPushed;

    private Vector3 startPosition;
    private Rigidbody rb;

    void Start()
    {
        startPosition = transform.position;
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float distance = Mathf.Abs(transform.position.y - startPosition.y);
        if (distance >= minDistance)
        {
            transform.position = new Vector3(transform.position.x, startPosition.y - minDistance, transform.position.z);
            if (!_wasPressed)
            {
                _wasPressed = true;
                OnPushed?.Invoke();
            }
        }
        else
        {
            _wasPressed = false;
        }
        if (transform.position.y > startPosition.y)
        {
            transform.position = new Vector3(transform.position.x, startPosition.y, transform.position.z);
        }
    }
}
