using UnityEngine;

public class Axe : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] private float speed;
    [SerializeField] private float leftAngle;
    [SerializeField] private float rightAngle;

    private bool clockWise;

    bool movingClockwise;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        clockWise = false;
    }

    // Update is called once per frame
    void Update()
    {
        Flip();
    }

    public void checkFlip()
    {
        if(transform.rotation.z > rightAngle)
        {
            clockWise = true;
        }
        if (transform.rotation.z < leftAngle)
        {
            clockWise = false;
        }
    }

    public void Flip()
    {
        checkFlip();
        if(clockWise)
        {
            rb.angularVelocity = -speed;
        }
        else
        {
            rb.angularVelocity = speed;
        }
    }
}
