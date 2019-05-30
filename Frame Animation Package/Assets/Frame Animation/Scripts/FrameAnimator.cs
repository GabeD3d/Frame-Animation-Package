using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrameAnimator : MonoBehaviour {   
    public List<FrameAnimation> animations;
    SpriteRenderer frameRenderer;
    int currentSprite = 0;
    [HideInInspector]
    public FrameAnimation currentAnim;
    public string defaultAnimation;
    [HideInInspector]
    public string prevName = "";

    float time;
    
    private void Awake() {
        frameRenderer = GetComponent<SpriteRenderer>();
        
        // Get all animations in this object
        //animations = new List<FrameAnimation>();
        // foreach (FrameAnimation anim in GetComponents<FrameAnimation>()) {
        //     animations.Add(anim);
        // }
    }

    private void Start() {
        // Set the default animation
        if (defaultAnimation != null) {
            currentAnim = GetAnimation(defaultAnimation);
        } else {
            currentAnim = animations[0];
            Debug.LogWarning("No default animation was provided. Using first animation loaded instead.");
        }
    }

    // Update is called once per frame
    void Update() {
        // Count time based on the animation speed
        time += Time.deltaTime * currentAnim.speed;

        // Animation speed is in frames per second
        if (time > 1) {
            time = 0;
            if (currentSprite < currentAnim.sprites.Length-1) {
                currentSprite += 1;
            } else {
                currentSprite = 0;
            }
        }

        frameRenderer.sprite = currentAnim.sprites[currentSprite];

    }

    public FrameAnimation GetAnimation(string name) {
        // Find animation with a matching name
        // Does not support animations with same name
        if (name != prevName) {
            foreach (FrameAnimation a in animations) {
                if (a.animationName == name) {
                    currentSprite = 0;
                    prevName = name;
                    return a;
                }
            }
            Debug.LogError("Animation requested could not be found");
            return null;
        }
        return currentAnim;
    }
}
