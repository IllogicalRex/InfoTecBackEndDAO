using InfoTecBackEnd.Model;
using System.Collections.Generic;

namespace InfoTecBackEnd.Interfaces
{
    public interface IEmpresa
    {
        List<EmpresaModel> getAllEmpresas();
        string deleteEmpresa(int id);
        string postEmpresa(EmpresaModel empresa);       
    }    

}