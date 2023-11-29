using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitDoor : MonoBehaviour
{
    public string sceneToLoad;
    void OnMouseDown()
    {
        if(GameManager.Instance.slotGameDone && GameManager.Instance.chessGameDone && GameManager.Instance.mapGameDone) {
            SceneManager.LoadScene(sceneToLoad);
        } else {
            
        }
    }
}
