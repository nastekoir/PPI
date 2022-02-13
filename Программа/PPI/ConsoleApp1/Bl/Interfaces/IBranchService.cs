using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Bl.Interfaces
{
    public interface IBranchService
    {
        void CreateBranch(string branchName);
        void DeleteBranch(Guid branchId);

        void RenameBranch(Guid branchId, string newName);
    }
}
