using APIContato.Models;
using APIContato.Service;
using Microsoft.AspNetCore.Mvc;
using WebApi_Funcionario.Moldels;
using WebApi_Funcionario.Service.FuncionarioService;

namespace WebApi_Funcionario.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContatoController : ControllerBase
    {
        private readonly IMailService _mailService;
        private readonly IContatoInterface _ContatoInterface;
        public ContatoController(IContatoInterface ContatoInterface, IMailService mailService)
        {
            _ContatoInterface = ContatoInterface;
            _mailService = mailService;
        }

        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<ContatoModel>>>> GetFuncionarios()
        {
            return Ok(await _ContatoInterface.GetContatos());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceResponse<ContatoModel>>> GetFuncionarioById(int id)
        {
            ServiceResponse<ContatoModel> serviceResponse = await _ContatoInterface.GetContatoById(id);

            return Ok(serviceResponse);
        }

        [HttpPost]
        public async Task<ActionResult<ServiceResponse<List<ContatoModel>>>> CreateContato(ContatoDto novoContato)
        {
            var data = await _ContatoInterface.CreateContato(novoContato.Create());
            //_mailService.SendMail(data.Dados.Email, "Cadastro com sucesso", "Seja bem vindo!", true);
            return Ok(data.Dados);
        }



        [HttpDelete]
        public async Task<ActionResult<ServiceResponse<List<ContatoModel>>>> DeleteFuncionario(int id)
        {
            ServiceResponse<List<ContatoModel>> serviceResponse = await _ContatoInterface.DeleteFuncionario(id);

            return Ok(serviceResponse);

        }

        //[HttpPost("email")]
        //public IActionResult SendMail([FromBody] SendMailModel sendMailModel)
        //{
        //    _mailService.SendMail(sendMailModel.Emails, sendMailModel.Subject, sendMailModel.Body, sendMailModel.IsHtml);
        //    return Ok();
        //}

    }
}