
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollission : MonoBehaviour {
    PlayerController playerControllerScript;

    private void OnCollisionEnter(Collision col)
    {
        if(col.gameObject)
        {
            playerControllerScript.enabled = false;
            Restart();
        }
    }

    void Restart()
    {
        SceneManager.LoadScene("Scene_1");
    }
}
