﻿using BusinessObjects;
using DAOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class BranchRepository
    {
        private readonly BranchDAO BranchDAO = null;
        public BranchRepository()
        {
            if (BranchDAO == null)
            {
                BranchDAO = new BranchDAO();
            }
        }
        public Branch AddBranch(Branch Branch) => BranchDAO.AddBranch(Branch);

        public void DeleteBranch(string id) => BranchDAO.DeleteBranch(id);

        public Branch GetBranch(string id) => BranchDAO.GetBranch(id);

        public List<Branch> GetBranches() => BranchDAO.GetBranches();

        public Branch UpdateBranch(string id, Branch Branch) => BranchDAO.UpdateBranch(id, Branch);
    }
}
