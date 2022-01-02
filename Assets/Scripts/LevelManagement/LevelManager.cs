using UnityEngine;
using UnityEngine.Tilemaps;

public class LevelManager : MonoBehaviour
{
    [SerializeField] private Tilemap tilemap;

    private Vector3 bottomLeftEdge;
    private Vector3 topRightEdge;

    // Start is called before the first frame update
    private void Start()
    {
        bottomLeftEdge = tilemap.localBounds.min + new Vector3(1f, 0.7f, 0f);
        topRightEdge = tilemap.localBounds.max + new Vector3(-1f, -0.7f, 0f);

        Player.Instance.SetLimits(bottomLeftEdge, topRightEdge);
    }

    // Update is called once per frame
    private void Update()
    {
    }
}