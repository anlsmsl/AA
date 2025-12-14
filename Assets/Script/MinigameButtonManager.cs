using UnityEngine;

public class MinigameButtonManager : MonoBehaviour
{
    // Bu fonksiyonu "OYUNA BAŞLA" butonuna bağlayacaksın
    public void StartMinigameMusic()
    {
        if (MusicManager.Instance != null)
        {
            MusicManager.Instance.PlayMinigameMusic();
        }
    }

    // Bu fonksiyonu minigame içindeki "ÇIKIŞ/BİTİR" butonuna bağlayacaksın
    public void StopMinigameMusic()
    {
        if (MusicManager.Instance != null)
        {
            MusicManager.Instance.PlayMainTheme();
        }
    }
}