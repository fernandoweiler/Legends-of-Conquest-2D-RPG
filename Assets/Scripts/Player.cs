using UnityEngine;

public class Player : MonoBehaviour
{
    public static Player Instance;

    [SerializeField] private Rigidbody2D playerRigidbody;
    [SerializeField] private Animator playerAnimator;

    [SerializeField] private int playerSpeed = 1;

    public string transitionName;

    private Vector3 bottomLeftEdge;
    private Vector3 topRightEdge;

    // Start is called before the first frame update
    private void Start()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
        }

        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    private void Update()
    {
        float horizontalMovement = Input.GetAxisRaw("Horizontal");
        float verticalMovement = Input.GetAxisRaw("Vertical");

        playerRigidbody.velocity = new Vector2(horizontalMovement, verticalMovement) * playerSpeed;

        playerAnimator.SetFloat("movementX", playerRigidbody.velocity.x);
        playerAnimator.SetFloat("movementY", playerRigidbody.velocity.y);

        if (horizontalMovement == 1 || horizontalMovement == -1 || verticalMovement == 1 || verticalMovement == -1)
        {
            playerAnimator.SetFloat("lastX", horizontalMovement);
            playerAnimator.SetFloat("lastY", verticalMovement);
        }

        transform.position =
            new Vector3(
                Mathf.Clamp(transform.position.x, bottomLeftEdge.x, topRightEdge.x),
                Mathf.Clamp(transform.position.y, bottomLeftEdge.y, topRightEdge.y)
            );
    }

    public void SetLimits(Vector3 bottomEdgeToSet, Vector3 topEdgeToSet)
    {
        bottomLeftEdge = bottomEdgeToSet;
        topRightEdge = topEdgeToSet;
    }
}