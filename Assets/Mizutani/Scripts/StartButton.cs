using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
    public void OnClickStartButton()
    {
        SceneManager.LoadScene("GameTest");
    }
    // Start is called before the first frame update
  
}
