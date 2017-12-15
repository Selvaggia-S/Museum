using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideosStart : MonoBehaviour
{
    public VideoPlayer Video_shoot, Video_bomb1, Video_bomb2, Video_host, Video_med;

    public void PlayShoot()
    {
        // Video_shoot.Play ();

        if (Video_shoot.isPlaying)
        {
            Video_shoot.Pause();

        }
        else
        {
            Video_shoot.Play();
        }



    }

    public void PlayBomb1()
    {
        //Video_bomb1.Play();
        if (Video_bomb1.isPlaying)
        {
            Video_bomb1.Pause();

        }
        else
        {
            Video_bomb1.Play();
        }

    }

    public void PlayBomb2()
    {
        //Video_bomb2.Play();
        if (Video_bomb2.isPlaying)
        {
            Video_bomb2.Pause();

        }
        else
        {
            Video_bomb2.Play();
        }

    }

    public void PlayHost()
    {
        //Video_host.Play();
        if (Video_host.isPlaying)
        {
            Video_host.Pause();

        }
        else
        {
            Video_host.Play();
        }
    }

    public void PlayMed()
    {
        //Video_med.Play();

        if (Video_med.isPlaying)
        {
            Video_med.Pause();

        }
        else
        {
            Video_med.Play();
        }
    }
}


