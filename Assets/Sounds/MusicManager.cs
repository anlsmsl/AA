using UnityEngine;

public class MusicManager : MonoBehaviour
{
    public static MusicManager Instance;

    [Header("Müzik Kaynağı")]
    public AudioSource audioSource;

    [Header("Müzikler")]
    public AudioClip mainTheme;     // Ana Menü ve Oda Müziği
    public AudioClip minigameTheme; // Minigame Müziği
    public AudioClip gameOverTheme; // Game Over Müziği

    private void Awake()
    {
        // Singleton yapısı (Sahneler arası yok olmayan tek patron)
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // --- Müzik Çalma Fonksiyonları ---

    public void PlayMainTheme()
    {
        // Eğer zaten bu müzik çalıyorsa hiç elleme (Kesinti olmasın)
        if (audioSource.clip == mainTheme && audioSource.isPlaying) return;

        audioSource.clip = mainTheme;
        audioSource.loop = true;
        audioSource.Play();
    }

    public void PlayMinigameMusic()
    {
        if (audioSource.clip == minigameTheme && audioSource.isPlaying) return;

        audioSource.clip = minigameTheme;
        audioSource.loop = true;
        audioSource.Play();
    }

    public void PlayGameOverMusic()
    {
        if (audioSource.clip == gameOverTheme && audioSource.isPlaying) return;

        audioSource.clip = gameOverTheme;
        audioSource.loop = true; 
        audioSource.Play();
    }
}