namespace Met.Sequence;

sealed class LinearSequence : Sequence
{
   private double current=1;
   private double steps =3;


   public override double Next()
   {
      double term = current;
      current += steps;
      return term;
      

   }

}