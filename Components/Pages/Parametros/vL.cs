namespace BlazorApp2.Components.Pages.Parametros
{
    public class vL
    {
        public vL(int id, string titulo, string categoria, string imgurl)
        {
            Id = id;
            Titulo = titulo;
            Categoria = categoria;
            imgURL = imgurl;
        }

        public int Id { get; set; }

        public string Titulo { get; set; } = string.Empty;

        public string Categoria { get; set; }

        public string imgURL { get; set; }



    }
}
