using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Bl.Interfaces
{
    /// <summary>
    ///  Интерфейс сервиса для работы с ветками обсуждений
    /// </summary>
    public interface IBranchService
    {
        /// <summary>
        ///  Создать ветку
        /// </summary>
        void CreateBranch(string branchName);

        /// <summary>
        ///  Удалить ветку
        /// </summary>
        void DeleteBranch(Guid branchId);

        /// <summary>
        ///  Переименовать ветку
        /// </summary>
        void RenameBranch(Guid branchId, string newName);
    }
}
