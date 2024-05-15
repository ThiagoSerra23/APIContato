namespace WebApi_Funcionario.Moldels
{
    public class ContatoDto
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Mensagem { get; set; }
        public ContatoDto() { }
        public ContatoModel Create()
        {
            return new ContatoModel
            {
                Id = 0,
                Nome = Nome,
                Telefone = Telefone,
                Email = Email,
                Mensagem = Mensagem,

            };
        }
    }
}
