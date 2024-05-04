namespace Biblioteca
{
    public class Libro
    {
        private List<string> paginas;

        public Libro() 
        { 
            paginas = new List<string>();
        }
        
        public void AgregarPaginas(string str)
        {
            this.paginas.Add(str);
        }

    }
}
