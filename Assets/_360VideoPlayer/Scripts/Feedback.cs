using UnityEngine;

public class Feedback : MonoBehaviour
{

    public float distance = 2.5f;

    public VideoManager videoManager = null;

    [Header("Icons")]
    public Sprite pause = null;
    public Sprite load = null;


    private SpriteRenderer spriteRenderer = null;


    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        SetupWithCamera();

        videoManager.onPause.AddListener(TogglePause);
        videoManager.onPause.AddListener(ToggleLoad);


    }

    private void OnDestroy()
    {
        videoManager.onPause.RemoveListener(TogglePause);
        videoManager.onPause.RemoveListener(ToggleLoad);



    }

    private void SetupWithCamera()
    {
        transform.parent = Camera.main.transform;
        transform.localRotation = Quaternion.identity;
        transform.localPosition = new Vector3(0, 0, distance);
    }

    private void TogglePause(bool isPaused)
    {
        spriteRenderer.sprite = pause;
        spriteRenderer.enabled = isPaused;
    }

    private void ToggleLoad(bool isLoaded)
    {
        spriteRenderer.sprite = load;
        spriteRenderer.enabled = isLoaded;
    }

}
