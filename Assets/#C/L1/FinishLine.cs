using UnityEngine;
using UnityEngine.SceneManagement; 

public class FinishLine : MonoBehaviour
{
    //อันนี้เข้าเส้นชัยจะไปฉากอื่นที่กำหนด
    public string nextSceneName; 

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Hero"))
        {
            SceneManager.LoadScene(nextSceneName);
        }
    }
}