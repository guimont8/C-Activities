using ExercicioInterface.Entities;

namespace ExercicioInterface.Services;

internal class PaypalService : IOnlinePaymentService
{
    public const double FeePercentage = 0.1;
    public const double MonthlyInterest = 0.2;
    public double PaymentFee(double amount) 
    {
        return amount * FeePercentage;
    }
    public double Interest(double amount, int months)
    {
        return amount * MonthlyInterest * months;
    }
            
}
