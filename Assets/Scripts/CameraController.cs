using Cinemachine;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private Player playerTarget;
    private CinemachineVirtualCamera virtualCamera;

    // Start is called before the first frame update
    private void Start()
    {
        playerTarget = FindObjectOfType<Player>();
        virtualCamera = GetComponent<CinemachineVirtualCamera>();

        virtualCamera.Follow = playerTarget.transform;
    }

    // Update is called once per frame
    private void Update()
    {
    }
}