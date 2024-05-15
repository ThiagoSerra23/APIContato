using Microsoft.EntityFrameworkCore;
using WebApi_Funcionario.DataContext;
using WebApi_Funcionario.Moldels;
using WebApi_Funcionario.Service.FuncionarioService;

namespace WebAPI_Video.Service.FuncionarioService
{
    public class ContatoService : IContatoInterface
    {
        private readonly ApplicationDbContext _context;
        public ContatoService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<ServiceResponse<ContatoModel>> CreateContato(ContatoModel novoContato)
        {
            ServiceResponse<ContatoModel> serviceResponse = new ServiceResponse<ContatoModel>();

            try
            {
                if (novoContato == null)
                {
                    serviceResponse.Dados = null;
                    serviceResponse.Mensagem = "Informar dados!";
                    serviceResponse.Sucesso = false;

                    return serviceResponse;
                }

                

                _context.Add(novoContato);
                await _context.SaveChangesAsync();

                serviceResponse.Dados = novoContato;


            }
            catch (Exception ex)
            {
                serviceResponse.Mensagem = ex.Message;
                serviceResponse.Sucesso = false;
            }

            return serviceResponse;
        }

        public async Task<ServiceResponse<List<ContatoModel>>> DeleteFuncionario(int id)
        {
            ServiceResponse<List<ContatoModel>> serviceResponse = new ServiceResponse<List<ContatoModel>>();

            try
            {
                ContatoModel contato = _context.Contatos.FirstOrDefault(x => x.Id == id);

                if (contato == null)
                {
                    serviceResponse.Dados = null;
                    serviceResponse.Mensagem = "Usuário não localizado!";
                    serviceResponse.Sucesso = false;

                    return serviceResponse;
                }


                _context.Contatos.Remove(contato);
                await _context.SaveChangesAsync();


                serviceResponse.Dados = _context.Contatos.ToList();

            }
            catch (Exception ex)
            {
                serviceResponse.Mensagem = ex.Message;
                serviceResponse.Sucesso = false;
            }

            return serviceResponse;
        }
        public async Task<ServiceResponse<ContatoModel>> GetContatoById(int id)
        {
            ServiceResponse<ContatoModel> serviceResponse = new ServiceResponse<ContatoModel>();

            try
            {
                ContatoModel funcionario = _context.Contatos.FirstOrDefault(x => x.Id == id);

                if (funcionario == null)
                {
                    serviceResponse.Dados = null;
                    serviceResponse.Mensagem = "Contato não localizado!";
                    serviceResponse.Sucesso = false;
                }

                serviceResponse.Dados = funcionario;

            }
            catch (Exception ex)
            {

                serviceResponse.Mensagem = ex.Message;
                serviceResponse.Sucesso = false;
            }

            return serviceResponse;
        }

        public async Task<ServiceResponse<List<ContatoModel>>> GetContatos()
        {
            ServiceResponse<List<ContatoModel>> serviceResponse = new ServiceResponse<List<ContatoModel>>();

            try
            {
                serviceResponse.Dados = _context.Contatos.ToList();

                if (serviceResponse.Dados.Count == 0)
                {
                    serviceResponse.Mensagem = "Nenhum dado encontrado!";
                }


            }
            catch (Exception ex)
            {

                serviceResponse.Mensagem = ex.Message;
                serviceResponse.Sucesso = false;
            }

            return serviceResponse;

        }

        

        
    }
}