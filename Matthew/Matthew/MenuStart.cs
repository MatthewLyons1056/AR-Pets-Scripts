using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityStandardAssets.CrossPlatformInput;

public class MenuStart : MonoBehaviour
{
    private void Update()
    {
        if (CrossPlatformInputManager.GetButtonDown("begin"))
        {
            StartCoroutine(letsgo());
            //SceneManager.LoadScene(1);
        }
        if (CrossPlatformInputManager.GetButtonDown("instructions"))
        {
            StartCoroutine(instruct());
            //SceneManager.LoadScene(2);
        }
        if (CrossPlatformInputManager.GetButtonDown("menuBack"))
        {
            SceneManager.LoadScene(0);
        }
    }

    IEnumerator letsgo()
    {
        AudioController.playButton3 = true;
        yield return new WaitForSeconds(.5f);
        SceneManager.LoadScene(1);
    }

    IEnumerator instruct()
    {
        AudioController.playButton3 = true;
        yield return new WaitForSeconds(.5f);
        SceneManager.LoadScene(2);
    }
}
