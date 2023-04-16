using HomeLoanApi.Models.Context;
using Microsoft.EntityFrameworkCore;

namespace HomeLoanApi.Models.Repository
{
    public class LoanDetailsRepo : ILoanDetailsRepo
    {

        private readonly HomeLoanContext _dbcontext;
       

        public async Task<IEnumerable<LoanDetails>> GetDetails()
        {
            return await _dbcontext.Loans.ToListAsync();
        }

        public async Task<LoanDetails> GetDetailsByID(int ID)
        {
            return await _dbcontext.Loans.FindAsync(ID);
        }

        public async Task<LoanDetails> InsertDetails(LoanDetails objDetails)
        {
            _dbcontext.Loans.Add(objDetails);
            await _dbcontext.SaveChangesAsync();
            return objDetails;
        }

        public async Task<LoanDetails> UpdateDetails(LoanDetails objDetails)
        {
            _dbcontext.Entry(objDetails).State = EntityState.Modified;
            await _dbcontext.SaveChangesAsync();
            return objDetails;
        }

        // public bool DeleteLoanDetails(int ID)
        //{
        //    bool result = false;
        //    var details = _dbcontext.Loans.Find(ID);
        //    if (details != null)
        //    {
        //        _dbcontext.Entry(details).State = EntityState.Deleted;
        //        _dbcontext.SaveChanges();
        //        result = true;
        //    }
        //    else
        //    {
        //        result = false;
        //    }
        //    return result;
        //}

        bool ILoanDetailsRepo.DeleteDetails(int ID)
        {
            bool result = false;
            var details = _dbcontext.Loans.Find(ID);
            if (details != null)
            {
                _dbcontext.Entry(details).State = EntityState.Deleted;
                _dbcontext.SaveChanges();
                result = true;
            }
            else
            {
                result = false;
            }
            return result;
        }
    }
}
