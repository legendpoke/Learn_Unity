using UnityEngine;

public class FlyAtPlayer : MonoBehaviour
{
    public float speed = 15.0f;
    [SerializeField] Transform player;
    Vector3 playerPosition;
    void objectFlyAtPlayer()
    {
        //transform.position = Vector3.MoveTowards(transform.position,playerPosition,0.1f);
        transform.position = Vector3.MoveTowards(transform.position, playerPosition, speed * Time.deltaTime);
    }
    void DestroyWhenReached()
    {
        if(transform.position == playerPosition)
        {
            Destroy(gameObject);
        }
    }
    private void Awake()
    {
        gameObject.SetActive(false);
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerPosition = player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        objectFlyAtPlayer();
        DestroyWhenReached();
    }
}
