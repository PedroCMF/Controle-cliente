using FS19_UC12_CLASSES.CLASSES;
using FS19_UC12_CLASSES_2.CLASSES;

class Program  //classe Program principal onde começa a tudo, comesça a rodar o codigo e chamar os outros
{

  //Metodo principal. se digitar. svm cria o metodo automatico
    static void Main(string[] args)  //Static=> Não muda, Void=> nao Retorna. É um valor vazio, args=> são argumentos que pode ser inserido na hora que comessar a classe
    {

      List<PessoaFisica> listaPF = new List<PessoaFisica>(); //Instanciar a lista para armazena pessoas fisica quando for adicionada

      //============================================FAZENDO MENU NO SISTEMA=================================================
     
      static void BarraCarregamento(string textocarregamento) //metodo para fazer o carregamento dos pontinhos iniciando
      {
      
        Console.WriteLine(textocarregamento); //mostra palavra iniciando

        for (var contador = 0; contador < 10; contador ++) //o for coloca 10 pontinhos

          {
             Console.Write(".");//Coloca pontinhos para carregar o codigo
            Thread.Sleep(500); //Tempo para mostrar o sietema carregando
          }

      }

     Console.ForegroundColor = ConsoleColor.DarkBlue; //muda a cor do menu
     Console.BackgroundColor = ConsoleColor.Magenta;

     BarraCarregamento("Iniciando");

     Console.WriteLine(@$"
     ***********************************************************************************
     *                                                                                 *
     *                     Bem vindo ao sistema de cadastro                            *
     *                      de pessoa fisica e juridica                                *
     *                                                                                 *
     ***********************************************************************************
     ");

     Thread.Sleep(500); //Tempo para mostrar o sietema carregando
     //Console.Clear(); //apaga os codigos acima, mostra somente os de baixo

     
     string opcao; //decalração de variavel
     string opcaopf;

   do {  //faça algo enquanto tal coisa for verdadeira

          Console.WriteLine(@$"
          
          ***********************************************************************************
          *              Selecione uma das opçoes abaixo                                    *
          ***********************************************************************************
          *                                                                                 *
          *                     1 - Pessoa Fisica                                           *
          *                     2 - Pessoa Juridica                                         *
          *                     0 - Sair 1                                                  *
          *                                                                                 *
          ***********************************************************************************
          ");
          
        opcao = Console.ReadLine();  //o ReadLine Pausa o codigo e a variavel opcao pega a digitaçao

        switch (opcao)
          {

        case "1":

           //================================PARA PESSOA FISICA====================================================
            Endereco end = new Endereco();//instancia a classe endereco 
            PessoaFisica novaPessoa = new PessoaFisica();  //instancia a classe PessoaFisica
             

             //========================è um menu dentro do outro usando o do while=========================
        do {
              Console.Clear(); //limpa os codigos acima

              Console.WriteLine(@$"
          
              ***********************************************************************************
              *              Selecione uma das opçoes abaixo                                    *
              ***********************************************************************************
              *                                                                                 *
              *                     1 - Cadastrar Pessoa Fisica                                 *
              *                     2 - Mostrar Pessoa Fisicas                                  *
              *                     0 - Voltar ao menu anterior                                 *
              *                                                                                 *
               ***********************************************************************************
             ");
            
            opcaopf = Console.ReadLine(); //pega o que o usuario digitar
            
            //cria um sub menu para cadastrar e mostrar pessoas
            switch(opcaopf)
            {
              case "1":
                  Console.WriteLine("Digite o nome da pessoa fisica que deseja cadastrar");
                  novaPessoa.nome = Console.ReadLine(); //guarda a opção que digitou

                  Console.WriteLine("Digite o cpf da pessoa fisica que deseja cadastrar");
                  novaPessoa.cpf = Console.ReadLine();

                  Console.WriteLine("Digite a data de nacimento da pessoa fisica que deseja cadastrar DD/MM/AAAA");
                  novaPessoa.dataNascimento = DateTime.Parse(Console.ReadLine());

                  bool idadevalida = (novaPessoa.validarDataNacimento(novaPessoa.dataNascimento));

                  if (idadevalida == true)
                  
                    {
                    Console.WriteLine("Cadastro Aprovado");
                    }

                  else

                    {
                      Console.WriteLine("Cadastro Reprovada por motivo de idade");
                    }

                  Console.WriteLine("Digite o rendimento para pessoa fisica que deseja cadastrar");
                  novaPessoa.rendimento = float.Parse(Console.ReadLine());

                  Console.WriteLine("Digite o endereço para pessoa fisica que deseja cadastrar");
                  end.lagradouro = Console.ReadLine();


                  //listaPF.Add(novaPessoa); //tudo que estiver no objeto novaPessoa. será adicionado na lista

                  
                  //=================================CRIAR ARQUIVO TXT=========================================================
                  //console readline (read = ler, line = linha)  console writeline(write = escrever, line = linha)

                   // StreamWriter banana = new StreamWriter($"{novaPessoa.nome}.txt"); //StreamWriter abre o arquivo e  pega o nome da pessoa que está no atributo nome é CRIA o arquivo com extenção
                   // banana.WriteLine(novaPessoa.nome);//dentro do arquivo escreve e pular uma linha
                  //banana.Close();

                    //O using abre e fecha o arquivo criado pelo StreamWriter
                    using (StreamWriter banana = new StreamWriter($"{novaPessoa.nome}.txt")) //StreamWriter abre o arquivo e  pega o nome da pessoa que está no atributo nome é CRIA o arquivo com extenção txt

                    {
                      
                    //escreve as informaçãos nas linhas do arquivo txt criado
                    // o WriteLine dentro do arquivo escreve e pular uma linha dentro do arquivo criado
                     banana.WriteLine(@$"
                     *************************************************************************************
                     nome: {novaPessoa.nome}
                     Data Nacimento: {novaPessoa.dataNascimento}
                     Rendimento: {novaPessoa.rendimento}
                     Logradouro: {end.lagradouro}
                     CPF: {novaPessoa.cpf}

                     *************************************************************************************
                     ");       

                    }

                break;

                case "2":

                   Console.Clear(); //limpa o console
                   Console.WriteLine("Digite o primeiro nome da pessoa que deseja procurar");

                  string pessoa = Console.ReadLine(); //pega o nome da pessoa digitado

                  using(StreamReader sr = new StreamReader($"{pessoa}.txt")) //O StreamReader le o arquivo ja criado de acordo com o nome da pessoa digitado

                  {
                      string linha;
                      while((linha = sr.ReadLine()) != null) //Enquanto(while) estiver linha no arquivo for diferente de null ler elas. Depois que acabar todas as linhas for null sai da rotina 

                      {
                          Console.WriteLine($"{linha}"); //imprimea as linhas na tela

                      }

                  }

                    Console.WriteLine("Aperte qualquer tecla para continuar"); //para sair aperte qualquer tecla
                    Console.ReadLine();

              break;


              case "3":


              break;

              default: //se nao escolher nenhuma opção

                Console.Clear();
                Console.WriteLine("Opção invalida, por favor digite uma opçáo valida");
                Thread.Sleep(2000);

             break;


            }

        } while (opcaopf != "0"); //Enquanto a opção for diferente de zero faz o loop

           

            break;

            //==========================Fim do sub menu=========================================================

        case "2":

            //=============================PARA PESSOA JURIDICA E VALIDAR CNPJ=============================================
        
          Endereco endpj = new Endereco();//instancia a classe endereco 
          endpj.Complemento = "Proximo ao Senai"; //chama os atributos que estao na classe endereço
          endpj.enderecoComercial = false;
          endpj.lagradouro = "Rua X";
          endpj.numero = 100;
          endpj.referencia = "batalhao da policia";

          PessoaJuridica PJ = new PessoaJuridica(); //Instancia a pessoa Juridica
          PJ.endereco = endpj; //chama os atributos da classe endereço na instancia da classe PessoaJuridica
          PJ.cnpj= "12345678000001";
          PJ.razaoSocial = "Bar do Pedro";
          PJ.inscricaoEstadual = "1111111111111111";
          
         // Console.WriteLine(PJ.razaoSocial);
          //Console.WriteLine(PJ.endereco.numero);
          //Console.WriteLine(PJ.endereco.referencia);
         // Console.WriteLine(PJ.inscricaoEstadual);
         
         //=======================chamada do metodo PagarImposto para pessoa Juridica============================
         PJ.rendimento = 9000;
         Console.WriteLine($"{PJ.PagarImposto(PJ.rendimento)},00"); //o metodo pagaimposto pessoajuridica chama o parametro rendimento com o valor passado pelo proprio paramerto rendimento. $=> interpolação
         //==================================================================================================

         //----------------------------------VALIDA CNPJ------------------------------------------------=======
          if (PJ.ValidaCNPJ(PJ.cnpj) == true) 

          {
                Console.WriteLine("CNPJ Valido");
          }
              else
          {
                Console.WriteLine("CNPJ Invalido");
          }
                
              break;

        case "0":
              Console.WriteLine("Obrigado por usar o nosso sistema");
              Console.WriteLine("Digite qualquer tecla para sair");
              Console.ReadLine(); // para sair do sistama quando quando apertar qualquer tecla

              BarraCarregamento("Finanlizando");

              break;

              default:
              Console.WriteLine("Opção inválida, digite uma das opçoes apresentadas");
              break;

          }

  } while ( opcao != "0"); //Enquanto a opção for diferente de zero faz o loop. Quando digitar zero sai do loop While

  Console.ResetColor(); //reseta a cor. no codigo abaixo fica a cor original


    }

}

