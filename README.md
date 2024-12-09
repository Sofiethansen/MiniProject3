Mini-Project 
But worse

Project name: Safe the RubberDucks

Name: Sofie Thisted Hansen

Student Number: 20234705

Link to Project: https://github.com/Sofiethansen/MiniProject3

Link to YouTube video of the game: 


The idea of the game

The first idea of the game wasn’t inspired by an existing game I enjoyed. I am not much of a gamer and had not really played many games until I started studying Medialogy. However, every semester, I found myself thinking it would be fun to create a game where you collect objects while being chased by enemies and killing them. To be honest, I really enjoy programming mechanics where you shoot and destroy objects. That’s what led me to create Save the RubberDucks.


The concept of Save the RubberDucks involves 20 RubberDucks hidden across 4-5 playgrounds, each with different colors. To start, the player needs to collect a weapon, as enemies will approach while searching for the RubberDucks. These enemies must be killed to successfully progress through the game.

The main parts of the game are:

•	Player – First person moving around using the keyboard WASD and jump using SPACE
•	Camera – Rotates with the mouse and are used to look around. In the middle of the camera there are a little point image, so the player now where to point.
•	Playground – 4-5 different colored playground using Pro Builder tools 
•	Animation – Door animations that opens using Ray casting
•	Weapon – Collecting a yellow weapon that shoots bullet using Escape
•	RubberDucks – 20 RubberDucks placed randomly around the playground
•	Enemies – The cube enemies that chase the player around
•	Score – A score count for each RubberDucks that gets collected


Game features:
•	Enemies are spawned randomly and using a coroutine
•	Timer – A timer to see how fast you can collect RubberDucks



How were the different parts of the course Utilized?
The game features a player controlled using Unity's New Input System, where movement is handled with the WSAD keys, and jumping is triggered by pressing the space bar. The camera is interactive, allowing the player to look around using mouse movements. 
Collectible objects can be picked up by pressing the 'E' key, and shooting bullets with the gun is mapped to the 'Escape' key. The various colored doors around the playground are programmed to animate and open when a Ray cast detects the object next to the doors. 

This interaction is controlled by a Boolean variable and an Animator, which activates when the 'E' key is pressed while the Ray cast is hitting a specific object. The enemies use a Rigidbody component, enabling them to move and interact with the environment. 
The pickup system for both the weapon and the rubber ducks relies on a box trigger, with interactions handled using the “OnTriggerEnter” method.

The enemy has a script that allows it to follow the player whenever a new enemy is spawned. The OnCollisionEnter method is used to eliminate enemies when they are hit by bullets, using Unity's physics system. Once a bullet collides with an enemy, the Destroy(collision.gameObject) function removes the enemy, clearing it from the scene until the next one is spawned.

The playground where the player moves is created using a combination of 3D objects and Pro Builder tools, providing platforms for the player to jump on. These objects are customized with Unity materials, giving each playground its own color.
In my Unity game, I incorporated UI elements for the score and timer using TextMeshPro to display text on the screen. TextMeshPro was also utilized for the Start and Game Over scenes. Both scenes featured buttons with on-click events, enabling methods from scripts to be assigned and ensuring the buttons navigate to the appropriate scenes.

Projects parts

•	InputManager
This script manages player input using Unity's new Input System, handling movement, looking, and jumping by delegating these actions to separate “PlayerMotor” and “PlayerLook” components.

•	Interactable
This script has an abstract base class for Interactable objects, providing a template for interaction with a prompt message and a method (Interact) to be overridden for specific interaction behaviors.

•	Keypad 
This script defines a keypad intractable object that toggles the open state of the animated door by setting an animation parameter “IsOpen” when interacted with

•	PlayerUI
This script manages the player's UI, specifically updating a TextMeshPro UI element with a prompt message to display to the player.


•	Bullet
This script defines a bullet's behavior in Unity, where the bullet destroys itself after a set lifetime or upon collision.

•	EnemySpawner
This script handles spawning enemies at random spawn points with a delay between every enemy

•	EnemyBehavior
This script defines enemy behavior in Unity, where the enemy constantly moves toward the player. When destroyed, it triggers the spawner to spawn a new enemy after a delay. 

•	PickUpItem
This script allows the player to pick up an item by pressing 'E' when within range. Once picked up, the item is positioned and attached to the player's holding position, with its physics disabled

•	ScoreManager
This script manages the player's score in Unity, updating the UI using TextMeshPro elements and triggering a game-over event when the score reaches a specified maximum.

•	RubberDuckCollect
This script allows the player to pick up a rubber duck by pressing "E" when in range, adding points to the player's score using the ScoreManager and destroying the duck afterward.

•	MainMenu
This script manages the main menu, allowing the player to start the game by loading the main scene.

•	GameOverScene
This script handles the Game Over screen, to either retry the game by reloading the main game scene or return to the main menu. 

Models and Prefabs

The RubberDucks: https://polyhaven.com/a/rubber_duck_toy
The chest: https://polyhaven.com/a/treasure_chest
Objects in Unity: Pro Builder Tools
The ground: A plane used from Unity
The bullets: A 3D sphere object
The enemies: 3D cube from Unity

Materials and texture: Unity Material

Scenes: Start scene with main menu, Main Scene and the game over scene








Time Management

TASK
TIME SPEND (In hours)
Unity and GitHub
0,5 
The idea of the game
A few days (This is my third project, after deleting the two others)
Setting the playground up
1.5 
Creating the functionality in Unity
25 hours
Writing the report
2.5
In Total
29,5 hours and some days


Used resources:
-	Lectures from the course
-	How to make a ray cast and animation
https://www.youtube.com/watch?v=gPPGnpV1Y1c&list=PLGUw8UNswJEOv8c5ZcoHarbON6mIEUFBC&index=2
-	Setting movement up
https://www.youtube.com/watch?v=rJqP5EesxLk&list=PLGUw8UNswJEOv8c5ZcoHarbON6mIEUFBC&index=1

-	Spawning objects - With the help of using AI tools

-	PickUpSystem - Methods used from third Semester Project 



