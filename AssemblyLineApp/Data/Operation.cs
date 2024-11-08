namespace AssemblyLineApp.Data
{
    public class Operation
    {
        public int OperationId { get; set; }
        public string Name { get; set; }
        public int OrderInWhichToPerform { get; set; }
        public Devices Device { get; set;}
    }
}
