using System.ComponentModel.DataAnnotations;

namespace T3_sts_adj.Models
{
    public class Libro
    {
        [Key]

        public int Id { get; set; }

        public string Titulo { get; set; }

        public string Autor { get; set; }

        public string Tema { get; set; }

        public string Editorial { get; set; }
        [Range(1900, 3000, ErrorMessage = "El año de publicación debe estar entre 1900 y 3000.")]
        public int AnioPublicacion { get; set; }
        [Range(10, 1000, ErrorMessage = "El número de páginas debe estar entre 10 y 1000.")]
        public int Paginas { get; set; }
        public string Categoria { get; set; }

    }
}
