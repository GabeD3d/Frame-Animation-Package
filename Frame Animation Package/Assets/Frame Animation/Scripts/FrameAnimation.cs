using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Frame Animation", menuName = "Gabe's Tools/Frame Animation", order = 1)]
public class FrameAnimation : ScriptableObject {
    public string animationName;
    public Sprite[] sprites;
    public float speed = 1;
    [HideInInspector]
    public int frameCount;

    // Start is called before the first frame update
    void Start() {
        frameCount = sprites.Length;
    }
}
