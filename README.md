[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/7qg5CCgx)
# HW2
## Devlog
The plan I wrote in the MG2 break-down activity connects to the code I wrote as the drawn out break-down visualized the differect actions and attributes each of the game objects like the player, ground, coin, and UI needed. For instance, in my break-down I wrote that the penguin/player jumps once when the SPACE bar is pressed. This connects to the code I wrote in the player class/script where I coded an if statement where if the SPACE key is pressed down and the player is grounded, then call the Jump() method, which adds force to the player's Rigidbody2D giving it the direction of Vector2.up and a magnitude equal to the jumpForce. Something that changed fom my original break-down visualization was that instead of the player collider detecting the coin in the Player class I would have it the other way aorund where the Coin class would detect the player's tag. This makes it so the player doesn't have to know about every type of collectable if there were more. It puts less responsibility on the Player. Keeps scripts more clearer and concise if the player class doesn't have to worry about every collectable.


## Open-Source Assets
If you added any other outside assets, list them here!
- [Sprout Lands sprite asset pack](https://cupnooble.itch.io/sprout-lands-asset-pack) - rabbit and item sprites
- [Pixel Penguin 32x32 Asset pack](https://legends-games.itch.io/pixel-penguin-32x32-asset-pack) - penguin sprites
- [Coins 2D](https://artist2d3d.itch.io/2d) - coin sprites