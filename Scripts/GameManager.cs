using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public int soalSaatIni;
    public GameObject panel ;
    public GameObject panelWin;
    public GameObject panelLose;
    public GameObject cekJawaban;
    [SerializeField] private string jawaban;
    public InputControl[] listInput;
    AudioManager audioManager;

     private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }

    //--------------------------------CEK JAWABAN----------------------------------------//
    public void CekJawaban()
    {
        string hasilInput = "";
        //looping tresing
        for (int i = 0; i < listInput.Length; i++)
        {
            string AmbilHuruf = listInput[i].AmbilHuruf();
            hasilInput += AmbilHuruf;
        }

        if(hasilInput.ToUpper() == jawaban.ToUpper())
        {
            //menang
            Debug.Log("Jawaban Benar");
            panelLose.SetActive(false);
            panelWin.SetActive(true);
            cekJawaban.SetActive(false);
            audioManager.PlaySFX(audioManager.benar);
            //panelLose.SetActive(false);
            
        }else
        {
            //game kalah
            Debug.Log("Jawaban SALAH");
            panelLose.SetActive(true);
            audioManager.PlaySFX(audioManager.salah);
        }
    }


    //---------------------------------------SAVE PROGRES & LOAD SCENE-----------------------------------//
    public void LevelSelanjutnyaTemaKuliner()
    {
        //saveprogres
        PlayerPrefs.SetInt("tmKuliner", soalSaatIni);
        //Ganti Scene
        SceneManager.LoadScene("KULINER "+ (soalSaatIni+1));
    }

    public void LevelSelanjutnyaTemaBuahdanSayuran()
    {
        //saveprogres
        PlayerPrefs.SetInt("tmBuahdanSayuran", soalSaatIni);
        //Ganti Scene
        SceneManager.LoadScene("BUAH "+ (soalSaatIni+1));
    }
    
    public void LevelSelanjutnyaTemaFloradanFauna()
    {
        //saveprogres
        PlayerPrefs.SetInt("tmFloradanFauna", soalSaatIni);
        //Ganti Scene
        SceneManager.LoadScene("FLORA "+ (soalSaatIni+1));
    }

    public void LevelSelanjutnyaTemaSenidanKerajinan()
    {
        //saveprogres
        PlayerPrefs.SetInt("tmSenidanKerajinan", soalSaatIni);
        //Ganti Scene
        SceneManager.LoadScene("SENI "+ (soalSaatIni+1));
    }

    public void LevelSelanjutnyaTemaKesehatan()
    {
        //saveprogres
        PlayerPrefs.SetInt("tmKesehatan", soalSaatIni);
        //Ganti Scene
        SceneManager.LoadScene("KESEHATAN "+ (soalSaatIni+1));
    }


    public void SAVETemaKuliner()
    {
        PlayerPrefs.SetInt("tmKuliner", soalSaatIni+1);
        SceneManager.LoadScene("menuTema");
    }

    public void SAVETemaBuah()
    {
        PlayerPrefs.SetInt("tmBuahdanSayuran", soalSaatIni+1);
        SceneManager.LoadScene("menuTema");
    }

    public void SAVETemaFlora()
    {
        PlayerPrefs.SetInt("tmFloradanFauna", soalSaatIni+1);
        SceneManager.LoadScene("menuTema");
    }

    public void SAVETemaSeni()
    {
        PlayerPrefs.SetInt("tmSenidanKerajinan", soalSaatIni+1);
        SceneManager.LoadScene("menuTema");
    }

    public void SAVETemaKesehatan()
    {
        PlayerPrefs.SetInt("tmKesehatan", soalSaatIni+1);
        SceneManager.LoadScene("menuTema");
    }
}
