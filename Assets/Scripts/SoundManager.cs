using UnityEngine;
using System.Collections;

public class SoundManager : MonoBehaviour {

    static SoundManager _instance = null;

    public AudioSource sfxSource;
    public AudioSource musicSource;

    // Use this for initialization
    void Start () {

        if (instance)
        {
            //Game manager already exists destory second copy
            DestroyImmediate(gameObject);
        }
        else
        {
            // Assign gameManager to variable _instance
            instance = this;

            // do not destory gamemanager when switching scenes
            DontDestroyOnLoad(this);
        }
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    public void playSingleSound(AudioClip clip)
    {
        sfxSource.clip = clip;

        sfxSource.Play();
    }

    public void musicHandler(AudioClip clip)
    {
        musicSource.clip = clip;

        musicSource.Play();
    }

    public static SoundManager instance
    {
        get
        {
            return _instance;
        }
        set
        {
            _instance = value;
        }
    }
}
