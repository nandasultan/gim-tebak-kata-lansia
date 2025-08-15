using UnityEngine;


public class AudioManager : MonoBehaviour
{

    [Header("---------Audio Source-----------")]
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource sfxSource;


    [Header("---------Music Source-----------")]
    public AudioClip BackgroundMusic;
    public AudioClip btnMenu;
    public AudioClip btnMain;
    public AudioClip btnPengaturan;
    public AudioClip btnKeluar;
    public AudioClip btnKeluar2;
    public AudioClip btnHint;
    public AudioClip btnHint2;
    public AudioClip salah;
    public AudioClip benar;
    public static AudioManager instance;

    private void Awake() 
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }else
        {
            Destroy(gameObject);
        }    
    }

    private void Start()
    {
        musicSource.clip = BackgroundMusic;
        musicSource.Play();
    }

    public void PlaySFX(AudioClip clip)
    {
        sfxSource.PlayOneShot(clip);
    }

}
