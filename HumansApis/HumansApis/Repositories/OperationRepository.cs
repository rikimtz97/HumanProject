namespace HumansApis.Repositories
{
    public class OperationRepository : IOperationRepository
    {
        public async Task<double> Plus(double a, double b, double c)
        {
            var mathematics = a + b + c;
            return mathematics;
            
        }
    }
}
