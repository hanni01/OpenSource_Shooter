using UnityEngine;
using UnityEngine.SceneManagement;

public class LobbyUI : MonoBehaviour
{
    public void OnClickStart()
    {
        SceneManager.LoadScene("Level_00");
    }
}