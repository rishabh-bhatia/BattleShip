# BattleShip
This exercise is based on the classic game “Battleship”.
1. Two players
2.  Each player has a 10x10 board
3.  During setup, players can place an arbitrary number of “battleships” on their board.
4. The ships are 1-by-n sized, must fit entirely on the board, must be aligned either
   vertically or horizontally, and cannot overlap.
5. During play, players take a turn “attacking” a single position on the opponent’s board,
and the opponent must respond by either reporting a “hit” on one of their battleships
(if one occupies that position) or a “miss”
6. A battleship is sunk if it has been hit on all the squares it occupies
7. A player wins if all of their opponent’s battleships have been sunk.

# The task
The task is to implement a Battleship state-tracker for a single player that must support the
following logic:
1. Create a board
2. Add a battleship to the board
3. Take an “attack” at a given position, and report back whether the attack resulted in a
hit or a miss
4. Return whether the player has lost the game yet (i.e. all battleships are sunk)

# Special instructions?
Well there are none. But if you're unable to open the project due to some reason. Try to create a new C# console project, delete it's program.cs file and copy all the .cs files from my repo to your new project. I created this project using VS Code if that helps.
