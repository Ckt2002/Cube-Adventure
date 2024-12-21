using UnityEngine;

public class SawBlade : MonoBehaviour
{
    [SerializeField] private float rotateSpeed;
    [SerializeField] private Transform posBegin;
    [SerializeField] private Transform posEnd;
    [SerializeField] private float speed;

    private bool turnBack = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f, 0f, rotateSpeed);

        if(transform.position.x >= posEnd.position.x)
        {
            turnBack = true;
        }
        if (transform.position.x <= posBegin.position.x)
        {
            turnBack = false;
        }
        if(turnBack)
        {
            transform.position = Vector2.MoveTowards(transform.position, posBegin.position, speed*Time.deltaTime);
        }
        else
        {
            transform.position = Vector2.MoveTowards(transform.position, posEnd.position, speed*Time.deltaTime);
        }
    }
}
