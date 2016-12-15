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

    public void blueKeyAudio()
    {
        AudioClip blueKey = EventSounds[0];
        SFXChannel.PlayOneShot(blueKey);
    }

    public void redKeyAudio()
    {
        AudioClip redKey = EventSounds[1];
        SFXChannel.PlayOneShot(redKey);
    }

    public void yellowKeyAudio()
    {
        AudioClip yellowKey = EventSounds[2];
        SFXChannel.PlayOneShot(yellowKey);
    }

    public void speedAudio()
    {
        AudioClip speed = EventSounds[3];
        SFXChannel.PlayOneShot(speed);
    }

    public void XPAudio()
    {
        AudioClip XP = EventSounds[4];
        SFXChannel.PlayOneShot(XP);
    }

    public void enemyAudio()
    {
        AudioClip enemy = EventSounds[5];
        SFXChannel.PlayOneShot(enemy);
    }

    public void victoryAudio()
    {
        AudioClip victory = EventSounds[6];
        SFXChannel.PlayOneShot(victory);
    }

}
