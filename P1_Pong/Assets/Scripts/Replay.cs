using UnityEngine;
using UnityEngine.SceneManagement;

public class Replay : MonoBehaviour
{
    public void ReplayGame()
    {
        Debug.Log("Replay button clicked!");

        SceneManager.LoadScene("SampleScene");
    }
}