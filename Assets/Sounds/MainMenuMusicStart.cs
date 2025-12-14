using UnityEngine;

public class MainMenuMusicStart : MonoBehaviour
{
    void Start()
    {
        // Oyun açılır açılmaz veya menüye dönülünce Ana Temayı çal
        if (MusicManager.Instance != null)
        {
            MusicManager.Instance.PlayMainTheme();
        }
    }
}