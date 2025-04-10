# Hero-Project
This is the hero project prompt for my intro to game dev class. It implements a list of features (see readme), art assets provided by instructor


Required features:

    Using prefabs for objects
    Key-M toggles between mouse and keyboard control
      DONE
    Space Bar fires eggs every 0.2 seconds
    Eggs travel at 40 unit/sec
    Eggs are destroyed when it hits enemy or goes out of the screen
    There are always 10 enemies
      IMPLEMENTED, UNTESTED
    Enemies are destroyed if they touch the Hero (arrow)
    Enemies lose 20% of their health, their alpha value becomes 80% of their previous value, when they collide with an egg. The 4th collision with an egg destroys the enemy. 
    When enemies are destroyed, they respawn at a random point at 90% os screen boundaries
      DONE
    Application status is displayed: Hero Mode, Number of eggs, Enemy count, Enemies Destroyed
    Key-Q quits or Pauses the application