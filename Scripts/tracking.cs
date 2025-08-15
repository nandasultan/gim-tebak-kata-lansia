using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class tracking : MonoBehaviour
{
    public VideoPlayer video;
    Slider tracker;
    bool on_drag = false;

    void Start()
    {
        tracker = GetComponent<Slider>();
        
    }

    public void OnDrag()
    {
        on_drag = true;
    }

    public void OnUp()
    {
        on_drag = false;
        float frame = (float)tracker.value * (float)video.frameCount;
        video.frame = (long)frame;
    }

    void Update()
    {
        if(video.isPlaying && !on_drag)
        {
            tracker.value = (float)video.frame/(float)video.frameCount;
        }
        
    }
}
