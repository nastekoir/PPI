using ConsoleApp1.Bl.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Services
{
    internal class BranchService : IBranchService
    {
        public void CreateBranch(string branchName)
        {
            //INSERT BranchTable branchName
        }

        public void DeleteBranch(Guid branchId)
        {
            //DELETE BranchTable WHERE Id=branchId
        }

        public void RenameBranch(Guid branchId, string newName)
        {
            //UPDATE BranchTable SET Name=newName WHERE Id=branchId
        }
    }
}
