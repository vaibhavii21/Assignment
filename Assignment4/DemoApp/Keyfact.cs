namespace Met.Sequence;
public abstract class key
{
    public static Sequence Linear()
    {
        var Seql = new LinearSequence();
        return Seql;
    }
    public static Sequence Power()
    {
        var Seqp = new PowerSequence();
        return Seqp;
    }

    private key() {}
}