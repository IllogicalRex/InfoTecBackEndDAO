using InfoTecBackEnd.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InfoTecBackEnd.Interfaces
{
    public interface IProjectBank
    {
        List<ProjectBankModel> GetAllProjects();
        ProjectBankModel GetProjectsById(int id);
        string DeleteProject(int project);
        ProjectBankModel UpdateProject(int id, ProjectBankModel order);
    }
}
