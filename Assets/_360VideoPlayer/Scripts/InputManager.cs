using UnityEngine;

public class InputManager : MonoBehaviour
{

    public VideoManager videoManager = null;

    private void Update()
    {

        if (!videoManager.IsVideoReady)
        {
            return;
        }


        OculusInput();
        KeyboardInput();
    }

    private void OculusInput()
    {
        if(OVRInput.GetDown(OVRInput.Button.One, OVRInput.Controller.All))
        {
            videoManager.PauseToggle();
        }

        if(OVRInput.GetDown(OVRInput.Button.PrimaryHandTrigger, OVRInput.Controller.LTouch))
        {
            videoManager.PreviousVideo();
        }

        if (OVRInput.GetDown(OVRInput.Button.PrimaryHandTrigger, OVRInput.Controller.RTouch))
        {
            videoManager.NextVideo();

        }

        if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger, OVRInput.Controller.LTouch))
        {
            videoManager.SeekBack();
        }

        if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger, OVRInput.Controller.RTouch))
        {
            videoManager.SeekForward();

        }
    }

    private void KeyboardInput()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            videoManager.PauseToggle();
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            videoManager.PreviousVideo();

        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            videoManager.NextVideo();

        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            videoManager.SeekBack();

        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            videoManager.SeekForward();

        }
    }
}
