# Darbot 9bit Engine

Darbot 9bit is a retro-inspired WinApp video game engine. It blends a classic 8‑bit look with modern Fluent design accents. The engine ships with a sample game called **9bit Drop** and provides a lightweight framework so you can build additional voxel‑style games.

## Features

- WinUI 3 desktop application packaged as MSIX
- Voxel rendering with 9‑bit (8‑bit + smooth edges) aesthetic
- Modular game loop with scene management
- Input abstraction for keyboard, mouse, and gamepad
- Built‑in sample game **9bit Drop** (Tetris clone)

## Building More Games

Games live in their own projects and reference `Darbot9BitEngine`. Each game implements a `IGame` interface and registers itself with the engine.

```
public interface IGame
{
    string Name { get; }
    void Initialize(GameContext context);
    void Update(GameContext context);
    void Render(GameContext context);
}
```

See the `9bitDrop` folder for a minimal example.

## Packaging

The solution uses the single‑project MSIX tooling. Running **Publish** in Visual Studio will produce `Darbot9Bit.msix` which installs the engine and sample game.

## Repository Layout

- `Darbot9BitEngine/` – core engine project
- `9bitDrop/` – sample Tetris implementation
- `style-guide.md` – design language specification
- `setup.ps1` – PowerShell setup script for new machines

## License

This sample code is released under the MIT License.
