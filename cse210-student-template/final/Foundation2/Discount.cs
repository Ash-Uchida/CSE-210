public class Discount
{
    private bool _discount;

    public Discount(bool discount)
    {
        _discount = discount;
    }

    public bool DoTheyHaveDiscount()
    {
        return _discount;
    }
}