using Microsoft.EntityFrameworkCore;
using ServerSideApp.interfaces;
using ServerSideApp.models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ServerSideApp.services
{
    public class Status : IStatus
    {
        private readonly ntellectyx_TestContext _context;
        public Status(ntellectyx_TestContext context) => _context = context;
        public async Task<int> DeleteStatusDetails(int statusId)
        {
            StatusDetails statusDetails = _context.StatusDetails.Find(statusId);
            if (statusDetails != null)
            {
                _context.Remove(statusDetails);
            }
            return await _context.SaveChangesAsync();
        }
        public async Task<IList<StatusDetails>> getStatusDetails() => await _context.StatusDetails.ToListAsync();
        public async Task<StatusDetails> getStatusDetailsByID(int statusId) => await _context.StatusDetails.FindAsync(statusId);
        public async Task<int> SaveStatusDetails(StatusDetails statusDetails)
        {
            _context.Add(statusDetails);
            return await _context.SaveChangesAsync();
        }
        public async Task<int> UpdateStatusDetails(int statusId, StatusDetails statusDetails)
        {
            StatusDetails statusDetail = _context.StatusDetails.Find(statusId);
            if (statusDetails != null)
            {
                statusDetail.Name = statusDetails.Name;
                statusDetail.Status = statusDetails.Status;
                statusDetail.ShopName = statusDetails.ShopName;
                statusDetail.StatusDate = statusDetails.StatusDate;
            }
            return await _context.SaveChangesAsync();
        }
    }
}
