using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AutoSwitchInput : MonoBehaviour
{
    public InputField nextInputField; // Variabel untuk menyimpan input field berikutnya

    void Start()
    {
        InputField inputField = GetComponent<InputField>(); // Mendapatkan komponen InputField pada objek ini

        // Menambahkan listener untuk event EndEdit
        inputField.onEndEdit.AddListener(delegate { OnEndEdit(inputField); });
    }

    void OnEndEdit(InputField inputField)
    {
        // Jika nilai input field saat ini sudah terisi
        if (!string.IsNullOrEmpty(inputField.text))
        {
            // Aktifkan input field berikutnya
            if (nextInputField != null)
            {
                nextInputField.Select();
                nextInputField.ActivateInputField();
            }
        }
    }
}

