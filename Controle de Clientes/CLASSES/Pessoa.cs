using FS19_UC12_CLASSES_2.CLASSES;

namespace FS19_UC12_CLASSES.CLASSES
{
    public abstract class Pessoa  //classe abstrata=> a classe abstrata cria um modelo, porem nao instancia. A intancia é feita pelas classe filhas da classe abstrata
    {
        public string? nome { get; set; } //? é para o campo nao ter valor nulo

        public Endereco endereco { get; set; } //chama a classe Endereco aqui dentro da classe pessoa com o nome endereco,para vir os atributos do entereço da classe pessoa

        public float rendimento {get; set;} //atributo do para ser chamado no metodo pagaimposto como parametro

        public abstract Double PagarImposto(float rendimento); //metodo da classe pessoa PagarImposto declarado como abstract portanto nao tem corpo({}). usando double sem void para retorna valor

    }
}