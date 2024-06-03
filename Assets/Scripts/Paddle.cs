using UnityEngine;

public class Paddle : MonoBehaviour
{
    public float Speed = 2.0f;
    public float MaxMovement = 2.0f;
    public MainManager MainManager; // Reference to MainManager

    // Start is called before the first frame update
    void Start()
    {
        // Find the MainManager instance if not set in the inspector
        if (MainManager == null)
        {
            MainManager = FindObjectOfType<MainManager>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        // Check if the game is over
        if (!MainManager.m_GameOver)
        {
            float input = Input.GetAxis("Horizontal");

            Vector3 pos = transform.position;
            pos.x += input * Speed * Time.deltaTime;

            if (pos.x > MaxMovement)
                pos.x = MaxMovement;
            else if (pos.x < -MaxMovement)
                pos.x = -MaxMovement;

            transform.position = pos;
        }
    }
}
