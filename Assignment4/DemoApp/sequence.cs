namespace Met.Sequence;
public abstract class Sequence
{

    public virtual double Sum(int count)
    {
        double Total = 0;
        for(int i=1; i<=count; ++i){
            Total+=Next();
    }
    return Total;
    }
    public abstract double Next();
}
