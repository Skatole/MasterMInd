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
        case Colors.Blue: return "B";
        case Colors.Green: return "G";
        case Colors.Black: return "b";
        case Colors.Red: return "R";
        case Colors.Yellow: return "Y";
        case Colors.White: return "W";
        case Colors.Purple: return "P";
        default: return "◯";
      }
    }
  }
}