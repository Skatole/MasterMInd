namespace MasterMind
{
  public enum Colors
  {
    Blue,
    Black,
    Red,
    Green,
    Yellow,
    White,
    Purple
  }

  public static class ColorOutput {
    public static string transferToAltChar(this Colors colors) {
      switch (colors)
      {
        case Colors.Blue: return "◯";
        case Colors.Green: return "◯";
        case Colors.Black: return "◯";
        case Colors.Red: return "◯";
        case Colors.Yellow: return "◯";
        case Colors.White: return "◯";
        case Colors.Purple: return "◯";
        default: return "◯";
      }
    }
  }
}