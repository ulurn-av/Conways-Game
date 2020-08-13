![GifforGit](https://user-images.githubusercontent.com/68646886/89990773-dab2f880-dca8-11ea-8b20-0ceb41510729.gif)

# Dll for "Game of Life"

Conway's Game of Life. This is repository includes a DLL which can help you to make a "Game of Life". 

## Contents
- [Methods](#Methods)

## Ctor

```sh
  public GameLogic(int rows, int columns, int density = 2) {}
```
You can use ctor with 3 or 2 parameters without them you can't.

For exemple you can call Ctor like that:
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

- CountOfNeighbors

- GetGeneration
