
<h1>Third Person Platformer 🎮</h1>  

This project is a **Unity-based Third-Person Platformer** where the player moves in the **direction of the camera**, jumps across platforms, and collects coins to increase their score.


## Features ✨  

- 🎥 **Camera-Based Movement**: Player moves in the direction of the camera using **WASD**.  
- 🏃 **Platformer Mechanics**: Smooth movement and jumping system for navigating obstacles.  
- 💰 **Coin Collection**: Coins are placed on platforms and disappear when collected.  
- 🏆 **UI Score Tracking**: Score updates dynamically when coins are collected.  
- 🚀 **Double-Jump**: Player can perform a **double jump** to reach higher platforms if needed.  

## Controls 🎮  

| Key      | Action                       |
|----------|------------------------------|
| `WASD`   | Move character               |
| `Space`  | Jump / Double Jump           |
| `Mouse`  | Rotate Camera                |
|`left SHIFT` | Dash                       |

## Environment & Gameplay 🌍  

The game consists of a **large flat plane** with obstacles:  

| Object       | Functionality                                  |
|-------------|----------------------------------------------|
| **Platforms** | Boxes placed to create jumping challenges  |
| **Coins**     | Collectibles placed on platforms; when player collects then coin sound effect  is triggered  |
| **Boundaries** | Invisible walls prevent the player from falling off |

## Bonus Features 🌟  
- 🎯 **Well-Tuned Movement** for a more **responsive** platforming experience  
- 🏗 **Single Responsibility Code Design** *(Each feature is modular and structured well)*  

## Development 🛠  

- 🎬 **Third-Person Free-Look Camera**: Uses **Cinemachine** for smooth camera control.  
- 🎮 **GameManager Implementation**: This efficiently handles scoring and coin logic.  

## Video Demo 📹  


## Installation 🏗  

1. Clone this repository:  
   ```sh
   git clone https://github.com/ThunderIW/COSC_416_Game_studio_3_UI
