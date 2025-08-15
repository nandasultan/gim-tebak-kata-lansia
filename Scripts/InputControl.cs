using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InputControl : MonoBehaviour
{
    public TMP_InputField[] inputs;

    // Index input field saat ini yang sedang diisi
    private int currentInputIndex = 0;

    void Start()
    {
        // Menambahkan listener pada setiap input field
        for (int i = 0; i < inputs.Length; i++)
        {
            int index = i; // Simpan nilai i dalam variabel lokal untuk menghindari perangkap penutup lingkup
            inputs[i].onValueChanged.AddListener((string text) => OnValueChange(text, index));
            inputs[i].characterLimit = 1; // Membatasi input field untuk hanya menerima 1 karakter
        }
    }

    // Dipanggil ketika teks diubah pada input field
    private void OnValueChange(string text, int currentIndex)
    {
        if (text.Length == 1) // Jika teks di input field memiliki panjang 1
        {
            MoveFocusToNextInput(currentIndex);
        }
        else if (text.Length == 0) // Jika teks di input field dihapus
        {
            MoveFocusToPreviousInput(currentIndex);
        }
    }

    // Pindahkan fokus ke input field berikutnya (jika ada)
    private void MoveFocusToNextInput(int currentIndex)
    {
        if (currentIndex < inputs.Length - 1)
        {
            inputs[currentIndex + 1].Select();
            inputs[currentIndex + 1].ActivateInputField();
            currentInputIndex = currentIndex + 1; // Update indeks input field saat ini
        }
        else
        {
            Debug.Log("Anda telah mencapai input field terakhir");
        }
    }

    // Pindahkan fokus ke input field sebelumnya (jika ada)
    private void MoveFocusToPreviousInput(int currentIndex)
    {
        if (currentIndex > 0)
        {
            inputs[currentIndex - 1].Select();
            inputs[currentIndex - 1].ActivateInputField();
            currentInputIndex = currentIndex - 1; // Update indeks input field saat ini
        }
        else
        {
            Debug.Log("Anda telah mencapai input field pertama");
        }
    }

    // Mengambil teks dari input field saat ini
    public string AmbilHuruf()
    {
        return inputs[currentInputIndex].text;
    }
}




