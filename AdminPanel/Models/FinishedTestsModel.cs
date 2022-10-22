namespace AdminPanel.Models
{
    public class FinishedTestsModel
    {
        public IEnumerable<TestModel> Tests { get; set; }
        public FinishedTestsModel()
        {
            Tests = new List<TestModel>();
        }
        public FinishedTestsModel(List<TestModel> tests)
        {
            Tests = tests;
        }
    }
}
