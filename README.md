# Frame Animation Package
A frame-by-frame animation system for Unity.

## How To Use
First, get your sprites ready. Slice them, name them something that makes sense to you.

### Creating FrameAnimation Files
In a folder somewhere in your project, right click and navigate to 'Gabe's Tools\Frame Animation'. Once you click that, a FrameAnimation file will be created; this file holds all the important information for your animation.

---

### Configuring FrameAnimation Files
The things you'll need to set up are as follows:
1) **Animation Name:** This will be how you reference this animation both in code and in the FrameAnimator component. This name does not have to be unique project-wide, but it must be unique per object. **AKA:** Don't give animations in the same object the same name.
2) **Sprites:** This is a simple list of images to cycle through. Set its size to however many frames of animation you need and drag & drop each frame image into the slots. Order is important (duh); the animation will start from 'Element 0'.
3) **Speed:** This represents how many frames per second the animation will cycle at. If your animation only has one sprite, I recommend setting this to 0 to avoid needless counting.

---

### Adding A FrameAnimator Component
I know, it can be confusing to have a *FrameAnimation* and a *FrameAnimator*, but they couldn't be more different. As we mentioned before, a FrameAnimation is a file that holds the data for one (1) animation. The FrameAnimator is a component that you must add to a game object in order to control the animations and hold all animations for that object.

First, create a new component inside an object that has a Sprite Renderer. If the object doesn't have a Sprite Renderer, one will be created.

The slots to set up a FrameAnimator are as follows:

1) **Animations:** This is  list of all the FrameAnimations this object will play at some point. Just set its size to however many animations you need and drag & drop them into their respective fiels. In this case, order is not important*.

2) **Default Animation:** This is the name of the animation to default to. If none is provided, the FrameAnimator will default to the first animation loaded.

\* As mentioned above, if no default animation name is provided the component will use the first one in the list. To avoid problems, I recommend **always** setting the first animation as the idle or default animation. Any other animations can go in whatever order.

---

### Switching Animations
First, create a FrameAnimator component reference in your script:
```
FrameAnimator animator;

void Awake() {
  animator = GetComponent<FrameAnimator>();
}
```
Then, wherever you want to change the animation, just set the ```currentAnim``` property of the animator to an animation returned from the ```GetAnimation(string name)``` function:
```
animator.currentAnim = animator.GetAnimation(ANIMATION NAME);
```
Don't forget to replace ```ANIMATION NAME``` for an actual string that matches an animation name!

---

That's it! This is all you need to know in order to use this animation package. If you have any feature requests just reach out to me on Twitter at [@elDaddyGabe](https://twitter.com/elDaddyGabe).

Have a great day!

\- Gabe
