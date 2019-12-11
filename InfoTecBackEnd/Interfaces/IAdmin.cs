using InfoTecBackEnd.Model;
namespace InfoTecBackEnd.Interfaces
{
    public interface IAdmin
    {
        AdminModel GetAdminInfo(string id);    
    }
    
}
