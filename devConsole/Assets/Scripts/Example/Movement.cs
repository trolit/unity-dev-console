using UnityEngine;

public class Movement : MonoBehaviour
{
    public static Movement Instance { get; private set; }

    public float speed = 2f;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
        }
    }

    public void SetPlayerSpeed(float value)
    {
        speed = value;
    }
}
