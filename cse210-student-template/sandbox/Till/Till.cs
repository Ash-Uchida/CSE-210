class Till
{
private enum BinIndex
{
    pennies = 0,
    nickles = 1,
    dimes = 2;

    public Till()
    {
        _bins = new List<Bin>();
        _bins.Add(new Bin(0.01, 50, "pennies"));
        _bins.Add(new Bin(0.05, 40, "mickles"));
    }

    public double TotalCash()
    {
        
    }
    public void ExchangeCash(int count, double value)
    {
        switch (value){
            case 0.01:
                _bins[(int)BinIndex.Pennies].Exchange(count);
                break;
            case 0.05:
                _bins[(int)BinIndex.Pennies].Exchange(count);
                break;
            default:
                string error = $"Invalid Cash value {value}";
                throw new Exception(error);

    }
        
    }

}
}