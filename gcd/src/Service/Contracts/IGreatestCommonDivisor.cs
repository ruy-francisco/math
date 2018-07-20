namespace Service.Contracts
{
    public interface IGreatestCommonDivisor: IMathOperator
    {
        int GetForTwoIntegers(int first, int second);
        int GetForNIntegers(int[] numbers);
    }
}