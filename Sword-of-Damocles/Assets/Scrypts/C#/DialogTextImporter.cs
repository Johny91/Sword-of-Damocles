using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System.Collections;

public class DialogTextImporter : MonoBehaviour
{
    // 0 - English
    // 1 - Portuguese
    public TextAsset []dialogAsset;
    public TextAsset []buttonsAsset;
    public TextAsset []nextDialogAsset;
    public TextAsset []nextButtonAsset;
    public Camera ActiveCamera;
    string [] dialogLines;
    string [] buttonsLines;
    int dialogNumber;
    //int buttonNumber;
    Text dialogText;
    //Text []buttonText;

	// Use this for initialization
	void Start ()
    {
        int index = 0; // Give values to the language selected (Fetch the value)
        if (dialogAsset[index])
        {
            dialogLines = (dialogAsset[index].text.Split("\n"[0]));
        }

        //if (buttonsAsset[index])
        //{
        //    buttonsLines = (buttonsAsset[index].text.Split("\n"[0]));
        //}

        dialogNumber = 1;
        //buttonNumber = 1;
    }

    // Update is called once per frame
    void Update()
    {
        //if (dialogNumber < 1)
        //   {
        //       dialogNumber = 1;
        //   }

        ActiveCamera.GetComponentInChildren<Canvas>().GetComponent<Text>().text = dialogLines[dialogNumber - 1];
    }

    public void ToggleCameraController()
    {
        if (ActiveCamera.GetComponent<CameraController>().enabled == false) ActiveCamera.GetComponent<CameraController>().enabled = true;
        else ActiveCamera.GetComponent<CameraController>().enabled = false;
    }
}
