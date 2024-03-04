using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneButton : MonoBehaviour
{
    public AudioClip hoverSound;
    public string nextSceneName;

    private AudioSource audioSource;
    private Button button;

    void Start()
    {
        audioSource = GetComponentInParent<AudioSource>(); // Assuming AudioSource is on parent
        button = GetComponent<Button>();
        if (button == null)
        {
            Debug.LogError("Button component not found on GameObject or its children.");
        }
        if (audioSource == null)
        {
            Debug.LogError("AudioSource component not found on parent GameObject.");
        }
    }

    public void OnHover()
    {
        if (hoverSound != null && audioSource != null)
        {
            audioSource.PlayOneShot(hoverSound);
        }
    }

    public void OnClick()
    {
        SceneManager.LoadScene(nextSceneName);
    }
}
