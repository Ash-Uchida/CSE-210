public class Discount
{
    private bool _discount;

    public Discount(bool discount)
    {
        _discount = discount;
    }

    public bool DoTheyHaveCoupon()
    {
        return _discount;
    }
}