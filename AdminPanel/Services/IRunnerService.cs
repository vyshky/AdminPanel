using AdminPanel.Models;

namespace AdminPanel.Services
{
    public interface IRunnerService
    {
        Task<FinishedTestsModel> GetFinishedTests();
    }
}
