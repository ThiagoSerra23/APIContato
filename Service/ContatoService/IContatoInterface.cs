using WebApi_Funcionario.Moldels;

namespace WebApi_Funcionario.Service.FuncionarioService
{
    public interface IContatoInterface
    {
        Task<ServiceResponse<List<ContatoModel>>> GetContatos();
        Task<ServiceResponse<ContatoModel>> CreateContato(ContatoModel novoContato);
        Task<ServiceResponse<ContatoModel>> GetContatoById(int id);
        Task<ServiceResponse<List<ContatoModel>>> DeleteFuncionario(int id);
        
    }
}