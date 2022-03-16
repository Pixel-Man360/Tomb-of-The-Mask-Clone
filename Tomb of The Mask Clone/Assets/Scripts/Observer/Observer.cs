using System;


public static class Observer
{
   public static event Action<bool> onPlayerTouchWalls;
   public static void OnPlayerTouchWalls(bool isOnWall) => onPlayerTouchWalls?.Invoke(isOnWall);

   public static event Action onPlayerStartedMoving;
   public static void OnPlayerStartedMoving() => onPlayerStartedMoving?.Invoke();

   public static event Action<bool> onGamePaused;
   public static void OnGamePaused(bool isPaused) => onGamePaused?.Invoke(isPaused);

   public static event Action onLevelOver;
   public static void OnLevelOver() => onLevelOver?.Invoke();

   public static event Action onGameOver;
   public static void OnGameOver() => onGameOver?.Invoke();
}