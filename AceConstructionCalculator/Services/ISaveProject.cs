using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AceConstructionCalculator.Models;

namespace AceConstructionCalculator.Services
{
    public interface ISaveProject
    {
        Task Save(ProjectResultsModel poject);
        Task<IEnumerable<ProjectResultsModel>> LoadResults();
        Task DeleteProject(ProjectResultsModel project);
    }
}