using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Player : MonoBehaviour
{
    public static Player playerInstance;

    [SerializeField] Rigidbody2D playerRigidbody;
    [SerializeField] Animator playerAnimator;
    [SerializeField] Tilemap tilemap;

    [SerializeField] int playerSpeed = 1;


    public string transitionName;

    private Vector3 bottomLeftEdge;
    private Vector3 topRightEdge;

    // Start is called before the first frame update
    void Start()
    {
        if (playerInstance != null && playerInstance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            playerInstance = this;
        }

        DontDestroyOnLoad(gameObject);

        bottomLeftEdge = tilemap.localBounds.min + new Vector3(1f, 0.7f, 0f);
        topRightEdge = tilemap.localBounds.max + new Vector3(-1f, -0.7f, 0f);
    }

    // Update is called once per frame
    void Update()
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
}
