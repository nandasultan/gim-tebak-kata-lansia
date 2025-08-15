using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
public class ButtonSound : MonoBehaviour
{

     AudioManager audioManager;
     private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }

    public void PlayMenu()
    {
        audioManager.PlaySFX(audioManager.btnMenu);
    }

    public void PlayMain()
    {
        audioManager.PlaySFX(audioManager.btnMain);
    }

    public void PlayPengaturan()
    {
        audioManager.PlaySFX(audioManager.btnPengaturan);
    }

    public void PlayKeluar()
    {
        audioManager.PlaySFX(audioManager.btnKeluar);
    }

    public void PlayKeluar2()
    {
        audioManager.PlaySFX(audioManager.btnKeluar2);
    }

    public void PlayHint()
    {
        audioManager.PlaySFX(audioManager.btnHint);
    }

    public void PlayHint2()
    {
        audioManager.PlaySFX(audioManager.btnHint2);
    }

    public void PlayGagal()
    {
        audioManager.PlaySFX(audioManager.salah);
    }

    public void PlayBenar()
    {
        audioManager.PlaySFX(audioManager.benar);
    }


}
