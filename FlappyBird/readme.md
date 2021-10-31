## Organizational list
1. Unity 2020.3.14f1 (https://unity3d.com/get-unity/download/archive)
2. Clone this repo (how to use git: https://www.youtube.com/watch?v=RPagOAUx2SQ&ab_channel=EXPLOI.T.)
3. To submit a task please send git repo (from your account) or just a zip file of project
4. You can ask questions in our chat group

## Theory
1. What is decomposition? https://en.wikipedia.org/wiki/Decomposition_(computer_science)
2. What is Black-box approache? https://en.wikipedia.org/wiki/Black_box
3. Flappy Bird  (https://youtu.be/lQz6xhlOt18?t=258)

## Decomposition of Flappy Bird
  
### 1. Rendering
- Show image
- Show background images
- Show obstacle images
### 2. Movement
- Image move up/down forward
- Image rotate
### 3. GamePlay
- Image can touch
- Event to trigger lose
- Pause game
### 4. UI
- Show UI 
- Start/Restart game
    
## Implementation

### 1. Rendering
- Png/JPG can be imported in Unity. SpriteEditor (https://www.youtube.com/watch?v=gbgIA3pwpHc&ab_channel=Unity)
- SpriteRenderer = show image (https://www.youtube.com/watch?v=VfAYSWpf7gg&ab_channel=Unity)
- GameObject is a thing that can be in the scene (https://www.youtube.com/watch?v=9rR3AS74UH0&ab_channel=Unity)
   
At this stage you should be able to make a STATIC scene with images. That looks something like flappy bird.

### 2. Movement
- Transform can move and rotate objects (https://www.youtube.com/watch?v=32JkMANaMpk&ab_channel=Unity)
- Time.deltaTime can help to move independend from frame-rate (https://www.youtube.com/watch?v=Gcoj3llfzSw&ab_channel=Unity)
- Input.GetMouseButtonUp(0) => detects if screen was touched (https://docs.unity3d.com/ScriptReference/Input.GetMouseButtonUp.html)

At this stage you should be able to move objects

### 3. GamePlay
- Rigidbody2D and colliders2D can performe touch detection (collision detection) (https://www.youtube.com/watch?v=rq6c2B_socs&ab_channel=Unity)
- Debug.Log prints text to the screen (ussefull for debuging info) (https://docs.unity3d.com/ScriptReference/Debug.Log.html)
- OnTriggerEnter2D can raise and event when it was touched (https://www.youtube.com/watch?v=Bc9lmHjqLZc&ab_channel=CodeMonkey)
- Time.scale = 0. Can pause the game. Time.scale = 1 (unpause) (https://www.youtube.com/watch?v=0VGosgaoTsw&ab_channel=Brackeys)
- [Suggestion] There you can make a state of gameplay. Like bool _isLose, in order to not performe detection of Inputs.

At this stage you should be able to detect if objects collides with each other and debug "Lose Text" and pause the game.

### 4. UI
- Canvas is to show UI (https://www.youtube.com/watch?v=JivuXdrIHK0&ab_channel=Brackeys)
- Image shows Png/JPG (https://docs.unity3d.com/2018.2/Documentation/ScriptReference/UI.Image.html)
- Buttons triggers and event whene it is pressed (https://docs.unity3d.com/2018.2/Documentation/ScriptReference/UI.Button.html)
- SceneManager Reloads the scene (there should be on scene) (https://www.youtube.com/watch?v=5x2tDagmFiQ&ab_channel=JimmyVegas)
- Linking an Scripts can be done by FindGameObjectOfType<> (https://www.youtube.com/watch?v=xqJkpm-iXfw&ab_channel=DilmerValecillos)

At this stage you should be able to show UI if player loses and restart the scene if Restart is pressed.

### 6. Homework
#### Make a "flappy bird"-like game, it should include basic mechanics.
1. A Bird that move up/down and forward(right)
2. If collides with obstacle it show the UI and stop the game.
3. On press Button it restarts the game
4. Game should have only one level
5. The level should repeat it self, random generation are topis for next lessons 
6. The game is expected to be playable

#### Additional tasks (carma bonus)
- Point system, see the original game
- Sounds/Effets, up to you
- Animation of UI

#### Make a decomposition of hellix jump 
- Gameplay video: https://www.youtube.com/watch?v=SNbzevhRBNk&ab_channel=AaronHuggett). 
- We will discuss together on next meeting
