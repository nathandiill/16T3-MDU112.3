using UnityEngine;
using System.Collections;

public class SoundManager : MonoBehaviour
{
    public static SoundManager Instance;

    void Awake()
    {
        Instance = this;
    }

    public AudioClip[] EventSounds;
    public AudioSource SFXChannel;

    // To call when blue key audio is needed
    public void blueKeyAudio()
    {
        AudioClip blueKey = EventSounds[0];
        SFXChannel.PlayOneShot(blueKey);
    }

    // To call when red key audio is needed
    public void redKeyAudio()
    {
        AudioClip redKey = EventSounds[1];
        SFXChannel.PlayOneShot(redKey);
    }

    // To call when yellow key audio is needed
    public void yellowKeyAudio()
    {
        AudioClip yellowKey = EventSounds[2];
        SFXChannel.PlayOneShot(yellowKey);
    }

    // To call when speed audio is needed
    public void speedAudio()
    {
        AudioClip speed = EventSounds[3];
        SFXChannel.PlayOneShot(speed);
    }

    // To call when XP audio is needed
    public void XPAudio()
    {
        AudioClip XP = EventSounds[4];
        SFXChannel.PlayOneShot(XP);
    }

    // To call when enemy audio is needed
    public void enemyAudio()
    {
        AudioClip enemy = EventSounds[5];
        SFXChannel.PlayOneShot(enemy);
    }

    // To call when victory audio is needed
    public void victoryAudio()
    {
        AudioClip victory = EventSounds[6];
        SFXChannel.PlayOneShot(victory);
    }

    // To call when fire audio is needed
    public void fireAudio()
    {
        AudioClip victory = EventSounds[7];
        SFXChannel.PlayOneShot(victory);
    }

    // To call when impact audio is needed
    public void impactAudio()
    {
        AudioClip victory = EventSounds[8];
        SFXChannel.PlayOneShot(victory);
    }
}
