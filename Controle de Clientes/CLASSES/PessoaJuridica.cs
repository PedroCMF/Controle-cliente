namespace FS19_UC12_CLASSES.CLASSES
{
    public class PessoaJuridica : Pessoa //PessoaJuridica herda os atributos de pessoa
    {
       public string? cnpj { get; set; }
       public string? razaoSocial { get; set; }

       public string? inscricaoEstadual { get; set; }
       
        //==================PESSOA JURIDICA=====================================================
        //Para rendimento de até 5000 reais, desconto de 6%
        //para rendimento entre 5.001,00 e 10.000,00 descoto de 8%
        //para rendimentos acima de 10.000,00 desconto de 10%
       public override double PagarImposto(float rendimento) //Devido o metodo pagarimposto ser abstract na classe pessoa usa se o override(sobrescrever) da classe Pessoa. Devido o metodo esta em uma classe filha e override ela tem corpo.  usando double sem void para retorna valor
        //Override sobrescreve os parametro do metodo atual quando ele passa nele pegando as informações do momento
        {

        if (rendimento <= 5000) //Para rendimento de até 5000 reais, desconto de 6%

        {
            return (rendimento/100) *6;

        }
         
         else if (rendimento > 5000 && rendimento <= 10000) //para rendimento entre 5.001,00 e 10.000,00 descoto de 8%

         {
            return (rendimento/100) *8;

         }

         else

         {
           
            return  (rendimento/100) *10; //para rendimentos acima de 10.000,00 desconto de 10%

         }

            
        }

    //Somente mermitir cadastro com 14 numeros
    //sendo os 4 antepenutimos 0001
    //configurar uma mensagem de erro 

    public bool ValidaCNPJ(string cnpj)
    {
    
        if((cnpj.Length >= 14) && (cnpj.Substring(cnpj.Length - 4)) == "0001") //Onde o cnpj for maior ou igual a 14. A substring pega os 4 antepenultimos numeros 0001 

        {
            return true;
        }

            return false;

    }
    

    }

}