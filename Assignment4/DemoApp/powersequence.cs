namespace Met.Sequence;
sealed class PowerSequence : Sequence,IResetable
{
  private double ratio = 3;
  private double current = 1;

  public override double Next()
  {
    double term = current;
    current *= ratio;
    return term;
  }
  public void Reset()
  {
    current = 1;

  }

  }

