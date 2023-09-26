namespace FS19_UC12_CLASSES_2.CLASSES

{
    public class Endereco //classe criada para somente para receber as informaçoes do endereço
    {
        public string? lagradouro { get; set; } //Atributos da classe endereço
        public int numero {get; set;}      
        public string? Complemento {get; set;}
        public bool enderecoComercial { get; set; }
        public string? referencia {get; set; }
        
    }
}