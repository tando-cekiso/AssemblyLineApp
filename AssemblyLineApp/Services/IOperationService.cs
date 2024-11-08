using AssemblyLineApp.Data;

namespace AssemblyLineApp.Services
{
    public interface IOperationService
    {
        void AddOperation(Operation operation, out string warning);

        //Iterating through our operations Enums
        IEnumerable<Operation> GetAllOperations();

        void DeleteOperation(int operationId);

        void UpdateOperation(Operation operation);
        int AddNew();
    }
}
