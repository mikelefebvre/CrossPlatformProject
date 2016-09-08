using UnityEngine;
using System.Collections;

public class SoundManager : MonoBehaviour {

    static SoundManager _instance = null;

    public AudioSource sfxSource;
    public AudioSource sfxSource2;
    public AudioSource musicSource;

    int sourceHandler = 0;
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
        if(sourceHandler % 2 == 0)
        {
            sfxSource.clip = clip;

            sfxSource.Play();
            sourceHandler++;
        }
        else if(sourceHandler % 2 == 1)
        {
            sfxSource2.clip = clip;

            sfxSource2.Play();
            sourceHandler++;
        }
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
