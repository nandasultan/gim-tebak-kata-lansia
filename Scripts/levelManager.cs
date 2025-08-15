using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class levelManager : MonoBehaviour
{
    [Header ("-----------------------GAME----------------------")]
    public Button[] listButtoncekTemaKuliner;
    public Button[] listButtoncekTemaBuahdanSayuran;
    public Button[] listButtoncekTemaFloradanFauna;
    public Button[] listButtoncekTemaSenidanKerajinan;
    public Button[] listButtoncekTemaKesehatan;
    [Header ("--------------------PEMBAHASAN-------------------")]
    public Button[] listButtoncekPembahasanTemaKuliner;
    public Button[] listButtoncekPembahasanTemaBuahdanSayuran;
    public Button[] listButtoncekPembahasanTemaFloradanFauna;
    public Button[] listButtoncekPembahasanTemaSenidanKerajinan;
    public Button[] listButtoncekPembahasanTemaKesehatan;



    //--------------------------------------------------KULINER------------------------------------------------//
    public void CekTemaKuliner()
    {
        int tebakLKulinerTerakhir;
        //udah pernah main Belum
        if (PlayerPrefs.HasKey("tmKuliner") == false )
        {
            //Jika belum akan masuk tebak1
            tebakLKulinerTerakhir = 1;
            PlayerPrefs.SetInt("tmKuliner", 1);
        }
        else
        {
        //Masuk Ke tebak terakhir 
        tebakLKulinerTerakhir = PlayerPrefs.GetInt("tmKuliner");
        }

        //Loping pengecekan level
        for (int i = 0; i < listButtoncekTemaKuliner.Length; i++)
        {
            if(i < tebakLKulinerTerakhir)
               listButtoncekTemaKuliner[i].interactable = true;
            else
               listButtoncekTemaKuliner[i].interactable = false;
        }
    }

        public void CekpmTemaKuliner()
    {
        int pmTebakKuliner;
        //udah pernah main Belum
        if (PlayerPrefs.HasKey("tmKuliner") == false )
        {
            //Jika belum akan masuk tebak1
            pmTebakKuliner = 1;
            PlayerPrefs.SetInt("tmKuliner", 1);
        }
        else
        {
        pmTebakKuliner = PlayerPrefs.GetInt("tmKuliner");

        }

        //Loping pengecekan level disini sepertinya
        for (int i = 0; i < listButtoncekPembahasanTemaKuliner.Length; i++)
        {
            if(i < pmTebakKuliner - 1)
               listButtoncekPembahasanTemaKuliner[i].interactable = true;
            else
               listButtoncekPembahasanTemaKuliner[i].interactable = false;
        }
    }


    //----------------------------------------------------BUAH/SAYURAN------------------------------------------ //
    public void CekTemaBuahdanSayuran()
    {
        int tebakLBuahdanSayuranTerakhir;
        //udah pernah main Belum
        if (PlayerPrefs.HasKey("tmBuahdanSayuran") == false )
        {
            //Jika belum akan masuk level1
            tebakLBuahdanSayuranTerakhir = 1;
            PlayerPrefs.SetInt("tmBuahdanSayuran", 1);
        }
        else
        {
        //Masuk Ke lvl terakhir main
        tebakLBuahdanSayuranTerakhir = PlayerPrefs.GetInt("tmBuahdanSayuran");
        }

        //Loping pengecekan level
        for (int i = 0; i < listButtoncekTemaBuahdanSayuran.Length; i++)
        {
            if(i < tebakLBuahdanSayuranTerakhir)
               listButtoncekTemaBuahdanSayuran[i].interactable = true;
            else
               listButtoncekTemaBuahdanSayuran[i].interactable = false;
        }
    }

        public void CekpmTemaBuahdanSayuran()
    {
        int pmTebakBuahdanSayuran;
        //udah pernah main Belum
        if (PlayerPrefs.HasKey("tmBuahdanSayuran") == false )
        {
            //Jika belum akan masuk level1
            pmTebakBuahdanSayuran = 1;
            PlayerPrefs.SetInt("tmBuahdanSayuran", 1);
        }
        else
        {
        //Masuk Ke lvl terakhir main
        pmTebakBuahdanSayuran = PlayerPrefs.GetInt("tmBuahdanSayuran");
        }

        //Loping pengecekan level disini sepertinya
        for (int i = 0; i < listButtoncekPembahasanTemaBuahdanSayuran.Length; i++)
        {
            if(i < pmTebakBuahdanSayuran - 1)
               listButtoncekPembahasanTemaBuahdanSayuran[i].interactable = true;
            else
               listButtoncekPembahasanTemaBuahdanSayuran[i].interactable = false;
        }
    }
    
    //--------------------------------------------------------------------FLORA/FAUNA-------------------------------------------------------------//
    public void CekTemaFloradanFauna()
    {
        int tebakFloradanFaunaTerakhir;
        //udah pernah main Belum
        if (PlayerPrefs.HasKey("tmFloradanFauna") == false )
        {
            //Jika belum akan masuk level1
            tebakFloradanFaunaTerakhir = 1;
            PlayerPrefs.SetInt("tmFloradanFauna", 1);
        }
        else
        {
        //Masuk Ke lvl terakhir main
        tebakFloradanFaunaTerakhir = PlayerPrefs.GetInt("tmFloradanFauna");
        }

        //Loping pengecekan level
        for (int i = 0; i < listButtoncekTemaFloradanFauna.Length; i++)
        {
            if(i < tebakFloradanFaunaTerakhir)
               listButtoncekTemaFloradanFauna[i].interactable = true;
            else
               listButtoncekTemaFloradanFauna[i].interactable = false;
        }
    }

        public void CekpmTemaFloradanFauna()
    {
        int pmTebakFloradanFauna;
        //udah pernah main Belum
        if (PlayerPrefs.HasKey("tmFloradanFauna") == false )
        {
            //Jika belum akan masuk level1
            pmTebakFloradanFauna = 1;
            PlayerPrefs.SetInt("tmFloradanFauna", 1);
        }
        else
        {
        //Masuk Ke lvl terakhir main
        pmTebakFloradanFauna = PlayerPrefs.GetInt("tmFloradanFauna");
        }

        //Loping pengecekan level disini sepertinya
        for (int i = 0; i < listButtoncekPembahasanTemaFloradanFauna.Length; i++)
        {
            if(i < pmTebakFloradanFauna - 1)
               listButtoncekPembahasanTemaFloradanFauna[i].interactable = true;
            else
               listButtoncekPembahasanTemaFloradanFauna[i].interactable = false;
        }
    }

    //--------------------------------------------SENI/KERAJINAN-------------------------------------------//
    public void CekTemaSenidanKerajinan()
    {
        int tebakSenidanKerajinanTerakhir;
        //udah pernah main Belum
        if (PlayerPrefs.HasKey("tmSenidanKerajinan") == false )
        {
            //Jika belum akan masuk level1
            tebakSenidanKerajinanTerakhir = 1;
            PlayerPrefs.SetInt("tmSenidanKerajinan", 1);
        }
        else
        {
        //Masuk Ke lvl terakhir main
        tebakSenidanKerajinanTerakhir = PlayerPrefs.GetInt("tmSenidanKerajinan");
        }

        //Loping pengecekan level
        for (int i = 0; i < listButtoncekTemaSenidanKerajinan.Length; i++)
        {
            if(i < tebakSenidanKerajinanTerakhir)
               listButtoncekTemaSenidanKerajinan[i].interactable = true;
            else
               listButtoncekTemaSenidanKerajinan[i].interactable = false;
        }
    }

        public void CekpmTemaSenidanKerajinan()
    {
        int pmTebakSenidanKerajinan;
        //udah pernah main Belum
        if (PlayerPrefs.HasKey("tmSenidanKerajinan") == false )
        {
            //Jika belum akan masuk level1
            pmTebakSenidanKerajinan = 1;
            PlayerPrefs.SetInt("tmSenidanKerajinan", 1);
        }
        else
        {
        //Masuk Ke lvl terakhir main
        pmTebakSenidanKerajinan = PlayerPrefs.GetInt("tmSenidanKerajinan");
        }

        //Loping pengecekan level disini sepertinya
        for (int i = 0; i < listButtoncekPembahasanTemaSenidanKerajinan.Length; i++)
        {
            if(i < pmTebakSenidanKerajinan - 1)
               listButtoncekPembahasanTemaSenidanKerajinan[i].interactable = true;
            else
               listButtoncekPembahasanTemaSenidanKerajinan[i].interactable = false;
        }
    }


    //----------------------------------------------KESEHATAN---------------------------------------------//
    public void CekTemaKesehatan()
    {
        int tebakKesehatanTerakhir;
        //udah pernah main Belum
        if (PlayerPrefs.HasKey("tmKesehatan") == false )
        {
            //Jika belum akan masuk level1
            tebakKesehatanTerakhir = 1;
            PlayerPrefs.SetInt("tmKesehatan", 1);
        }
        else
        {
        //Masuk Ke lvl terakhir main
        tebakKesehatanTerakhir = PlayerPrefs.GetInt("tmKesehatan");
        }

        //Loping pengecekan level
        for (int i = 0; i < listButtoncekTemaKesehatan.Length; i++)
        {
            if(i < tebakKesehatanTerakhir)
               listButtoncekTemaKesehatan[i].interactable = true;
            else
               listButtoncekTemaKesehatan[i].interactable = false;
        }
    }

        public void CekpmKesehatan()
    {
        int pmTebakKesehatan;
        //udah pernah main Belum
        if (PlayerPrefs.HasKey("tmKesehatan") == false )
        {
            //Jika belum akan masuk level1
            pmTebakKesehatan = 1;
            PlayerPrefs.SetInt("tmKesehatan", 1);
        }
        else
        {
        //Masuk Ke lvl terakhir main
        pmTebakKesehatan = PlayerPrefs.GetInt("tmKesehatan");
        }

        //Loping pengecekan level disini sepertinya
        for (int i = 0; i < listButtoncekPembahasanTemaKesehatan.Length; i++)
        {
            if(i < pmTebakKesehatan - 1)
               listButtoncekPembahasanTemaKesehatan[i].interactable = true;
            else
               listButtoncekPembahasanTemaKesehatan[i].interactable = false;
        }
    }

    //----------------------------------------------PILIH SOAL------------------------------------------//
    public void pilihSoalKuliner(string levelBerapa)
    {
        SceneManager.LoadScene("KULINER " + levelBerapa);
    }

    public void pilihSoalBuahdanSayuran(string levelBerapa)
    {
        SceneManager.LoadScene("BUAH " + levelBerapa);
    }

    public void pilihSoalFloradanFauna(string levelBerapa)
    {
        SceneManager.LoadScene("FLORA " + levelBerapa);
    }

    public void pilihSoalSenidanKerjinan(string levelBerapa)
    {
        SceneManager.LoadScene("SENI " + levelBerapa);
    }

    public void pilihKesehatan(string levelBerapa)
    {
        SceneManager.LoadScene("KESEHATAN " + levelBerapa);
    }

    //------------------------------------------Pembahasan----------------------------------------//
        public void pilihPmSoalKuliner(string levelBerapa)
    {
        SceneManager.LoadScene("pmKULINER " + levelBerapa);
    }

    public void pilihPmSoalBuahdanSayuran(string levelBerapa)
    {
        SceneManager.LoadScene("pmBUAH " + levelBerapa);
    }

    public void pilihPmSoalFloradanFauna(string levelBerapa)
    {
        SceneManager.LoadScene("pmFLORA " + levelBerapa);
    }

    public void pilihPmSoalSenidanKerjinan(string levelBerapa)
    {
        SceneManager.LoadScene("pmSENI " + levelBerapa);
    }

    public void pilihPmKesehatan(string levelBerapa)
    {
        SceneManager.LoadScene("pmKESEHATAN " + levelBerapa);
    }

    //------------------------------------------RESET GAME---------------------------------------//
    public void resetGame()
    {
        PlayerPrefs.DeleteKey("tmKuliner");
        PlayerPrefs.DeleteKey("tmBuahdanSayuran");
        PlayerPrefs.DeleteKey("tmFloradanFauna");
        PlayerPrefs.DeleteKey("tmSenidanKerajinan");
        PlayerPrefs.DeleteKey("tmKesehatan");
       
    }

}

