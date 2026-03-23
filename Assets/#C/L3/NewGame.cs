using UnityEngine;
using UnityEngine.SceneManagement;

public class NewGame : MonoBehaviour
{
    // ฟังก์ชันสำหรับกดปุ่มแล้วไปฉากถัดไป
    public void LoadGame(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
