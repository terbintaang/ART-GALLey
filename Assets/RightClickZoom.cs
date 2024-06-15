using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float zoomSpeed = 10f;
    public float moveSpeed = 5f;
    public float minZoom = 5f;
    public float maxZoom = 20f;
    public float zoomDuration = 1f; // Durasi zoom dalam detik

    private Vector3 targetPosition;
    private float targetZoom;
    private bool isZooming = false;
    private float zoomTime = 0f;

    void Update()
    {
        if (isZooming)
        {
            zoomTime += Time.deltaTime;
            float t = Mathf.Clamp01(zoomTime / zoomDuration);

            // Lerp position and zoom
            transform.position = Vector3.Lerp(transform.position, targetPosition, t);
            Camera.main.orthographicSize = Mathf.Lerp(Camera.main.orthographicSize, targetZoom, t);

            // Stop zooming when done
            if (t >= 1f)
            {
                isZooming = false;
            }
        }
    }

    public void ZoomToObject(Transform target)
    {
        targetPosition = new Vector3(target.position.x, target.position.y, transform.position.z);
        targetZoom = Mathf.Clamp(Camera.main.orthographicSize - zoomSpeed, minZoom, maxZoom);
        isZooming = true;
        zoomTime = 0f;
    }
}
