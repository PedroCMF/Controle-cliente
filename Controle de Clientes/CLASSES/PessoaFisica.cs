namespace FS19_UC12_CLASSES.CLASSES
{
    public class PessoaFisica : Pessoa //PessoaFisica herda os atributos de pessoa
    {
        public string? cpf {get; set;}
        public DateTime dataNascimento { get; set; }
        
        //==================PESSOA FISICA=====================================================
        //Para rendimento de até 1500 reais, isento (isento 0)
        //para rendimento maior que 1500 e menor ou igual 5000 descoto de 3%  
        //para rendimentos acima de 5000 desconto de 5%
        public override Double PagarImposto(float rendimento) //Devido o metodo pagarimposto ser abstract na classe pessoa usa se o override(sobrescrever) da classe Pessoa. usando double sem void para retorna valor
        //Override sobrescreve os parametro do metodo quando ele passa nele pegando as informações do momento
        {
            if (rendimento <= 1500) //Para rendimento de até 1500 reais, isento (isento 0)

            {
               return 0; //desconto
            }
             //Usando o else if testa mais uma condiçao
            else if(rendimento > 1500 && rendimento  <= 5000 )  //para rendimento maior que 1500 e menor ou igual 5000 descoto de 3%  

            {
             return rendimento * .03; //para rendimento maior que 1500 e menor ou igual 5000 descoto de 3%  

            }

            else

            {
  
                return (rendimento/100) * 5;  //para rendimentos acima de 5000 desconto de 5%
            }

        }

        public bool validarDataNacimento(DateTime dataNascimento) //metodo para retorna datA ATUAL
        {
         
         DateTime dataatual = DateTime.Today; //pega a data atual do sistema
         double anos = (dataatual - dataNascimento).TotalDays / 365;  //calculo da data de nacimento da pessoa
         
         if (anos >= 18) //validação de datas

         {
            return true;
         }

         else

         {
            return false;
         }

        }
    }


}