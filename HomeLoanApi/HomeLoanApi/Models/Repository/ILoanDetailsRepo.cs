namespace HomeLoanApi.Models.Repository
{
    public interface ILoanDetailsRepo
    {
        Task<IEnumerable<LoanDetails>> GetDetails();
        Task<LoanDetails> GetDetailsByID(int ID);
        Task<LoanDetails> InsertDetails(LoanDetails objDetails);
        Task<LoanDetails> UpdateDetails(LoanDetails objDetails);
        bool DeleteDetails (int ID);

    }
}
