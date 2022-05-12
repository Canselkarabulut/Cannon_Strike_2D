using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayBtn : MonoBehaviour
{
    public void PlayTiklandi()
    {
        SceneManager.LoadScene(1);
    }
    public void TryAgainBtn()
    {
        SceneManager.LoadScene(1);
    }
}
