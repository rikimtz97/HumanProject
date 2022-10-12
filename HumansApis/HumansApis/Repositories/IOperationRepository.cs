namespace HumansApis.Repositories
{
    public interface IOperationRepository
    {
        Task<double> Plus(double a, double b, double c);
    }
}
