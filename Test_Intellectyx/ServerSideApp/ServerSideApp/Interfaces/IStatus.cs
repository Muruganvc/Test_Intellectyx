using ServerSideApp.models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ServerSideApp.interfaces
{
    public interface IStatus
    {
        Task<IList<StatusDetails>> getStatusDetails();
        Task<StatusDetails> getStatusDetailsByID(int statusId);

        Task<int> SaveStatusDetails(StatusDetails statusDetails);
        Task<int> UpdateStatusDetails(int statusId, StatusDetails statusDetails);
        Task<int> DeleteStatusDetails(int statusId);
    }
}
