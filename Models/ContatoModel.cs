using System.ComponentModel.DataAnnotations;


namespace WebApi_Funcionario.Moldels
{
    public class ContatoModel
    {
        public ContatoModel()
        {

        }
        public ContatoModel(int id, string nome, string telefone, string email, string mensagem)
        {
            Id = id;
            Nome = nome;
            Telefone = telefone;
            Email = email;
            Mensagem = mensagem;
        }

        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Mensagem { get; set; }

    }
}
