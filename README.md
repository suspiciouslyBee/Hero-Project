# Hero-Project
This is the hero project prompt for my intro to game dev class. It implements a list of features (see readme), art assets provided by instructor


Required features:

    Using prefabs for objects
        For all non-singleton objects
    Key-M toggles between mouse and keyboard control
      DONE
    Space Bar fires eggs every 0.2 seconds
      DONE
    Eggs travel at 40 unit/sec
        DONE, tied to delta time
    Eggs are destroyed when it hits enemy or goes out of the screen
        DONE
    There are always 10 enemies
      DONE?
    Enemies are destroyed if they touch the Hero (arrow)
      DONE
    Enemies lose 20% of their health, their alpha value becomes 80% of their previous value, when they collide with an egg. The 4th collision with an egg destroys the enemy.
        "FAKED": converted into a more modular exponent function (so its continious for all health states)
        DONE : player does 1/4 to base enemy. this is manually done on purpose as im anticipating
        other types of planes
    When enemies are destroyed, they respawn at a random point at 90% os screen boundaries
      Done
    Application status is displayed: Hero Mode, Number of eggs, Enemy count, Enemies Destroyed
        DONE
    Key-Q quits or Pauses the application