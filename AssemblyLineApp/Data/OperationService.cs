using AssemblyLineApp.Services;
using System.ComponentModel;

namespace AssemblyLineApp.Data
{
    public class OperationService : IOperationService
    {

        private readonly List<Operation> _operations = new();



        //public OperationService() {

        //    _operations.Add(new Operation
        //    {
        //        OperationId = 1,
        //        Name = "Name",
        //        Device = new Devices { DeviceId = 1,Name="LaserCutter ",DeviceType = DeviceType.QualityAssuranceScanner},
        //    });

        //    _operations.Add(new Operation
        //    {
        //        OperationId = 2,
        //        Name = "Name",
        //        Device = new Devices { DeviceId = 2, Name = "Quality Scanner", DeviceType = DeviceType.QualityAssuranceScanner },
        //    });
        //}
        public void AddOperation(Operation operation, out string warning)
        {
            warning = string.Empty;


            // give a unique OperationId by finding the max ID and incrementing it
            operation.OperationId = _operations.Any() ? _operations.Max(op => op.OperationId) + 1 : 1;
            _operations.Add(operation);
        }


        public void DeleteOperation(int operationId)
        {
            // Delete 
            var operationToRemove = _operations.FirstOrDefault(op => op.OperationId == operationId);
            if (operationToRemove != null)
            {
                _operations.Remove(operationToRemove);
            }
        }

        public int AddNew()
        {
            return _operations.Any() ? _operations.Max(op => op.OrderInWhichToPerform) + 1 : 1;
        }

        public IEnumerable<Operation> GetAllOperations() => _operations;



        public void UpdateOperation(Operation updatedOperation)
        {
            var operation = _operations.FirstOrDefault(op => op.OperationId == updatedOperation.OperationId);
            if (operation != null)
            {
                operation.Name = updatedOperation.Name;
                operation.Device = updatedOperation.Device;
                operation.OrderInWhichToPerform = updatedOperation.OrderInWhichToPerform;
            }
        }

    }
}
