# fairyfrogger
Classic 2D game remake

Basic Requirements:


Art:
This game contains an animated player sprite, four enemy sprites, a basic particle effect, and two different backgrounds for each level. Frogger itself does not have very detailed characters, animations or environments so we took advantage of this by creating a stylized character and enemies to fit the theme that we were going for. The menu has art that is also contained in the game: the end goal so players can get an easy clue as to what they should look for at the end of the game. Frogger's minimalist style was a bit tricky to mimic for the environments since we didn't want the game to look empty so some liberties were taken when designing the levels.

Code:
While working on fairy frogger, we decided that each enemy would have its own code; the cat paw, roach's, and rats. The enemies have simple behaviors that alternate between moving forwards and backwards. The green goo is an environmental hazard that damages the player when collision is detected. The key was coded as a transition to the next level, and the win condition is determined by the player colliding with the cage. The lose condition is determined by the current lives the player has left. it was difficult to implement ridable rats, our idea was to make them work similar to the logs in the original frogger but we settled with making them an enemy

Tech:
Game has two complete levels with lose states in both and a win state in the second after completing objective. 
There is an edge collider to disable the player from exiting the game boundaries. The menu screen has a start button, exit button, 
about button and a volume warning (issues with implementing sound where the lose/win sounds were much louder than the other sounds). 
The about section of the start menu has controls, objectives and a credits section complete with a back button to return to the start 
screen to avoid dead ends. Both game over and win states have text and buttons to quit and return to start menu.

Other Game Elements:
All art/assets (besides keyboard key art assets) were created by Gracie Sanabria. All music/sounds (besides key collection sound and click 
sound for start button) were created by Melissa Jackson. All fonts from Google Fonts. (https://fonts.google.com, https://writingduels.itch.io/free-sound-effects, 
https://souptonic.itch.io/souptonic-sfx-pack-1-ui-sounds, https://beamedeighth.itch.io/simplekeys-animated-pixel-keyboard-keys)
