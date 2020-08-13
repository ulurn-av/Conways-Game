![GifforGit](https://user-images.githubusercontent.com/68646886/89990773-dab2f880-dca8-11ea-8b20-0ceb41510729.gif)

# Dll for "Game of Life"

Conway's Game of Life. This is repository includes a DLL which can help you to make a "Game of Life". 

## Contents
- [Ctor](#Ctor)
- [Methods](#Methods)
- [Download](#download-a-dll)

## Ctor

```sh
  public GameLogic(int rows, int columns, int density = 2) {}
```
You can use ctor with 3 or 2 parameters without them you can't.

For exemple you can call ctor like that:
```sh
  static GameLogic gameLogic = new GameLogic
  (
      rows: Console.WindowHeight,
      columns: Console.WindowWidth,
      density: density
  );
```
Or without density.

## Methods

- Generation
```sh
  public void Generation() {}
```
Method is using without parameters, and using for build a next generation.

- CountOfNeighbors

```sh
  private int CountOfNeighbors(int x, int y)
```
Method is using with 2 parameters, and using by method Generation for count of neighbors cell.
Generally you won't use this method he is exist for Generation method.

- GetGeneration

```sh
  public bool[,] GetGeneration()
```
GetGeneration is return an array bool[,]. This method using for getting a generation and then output it in Console or PictureBox in Windows Forms.

# Download a Dll
- https://github.com/breath-of-air/Conways-Game/raw/master/Engine%20of%20the%20game/Engine.dll

