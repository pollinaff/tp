
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace tp_laba2.Models
{
    public class FilmStudio
    {
        public int Id { get; set; }

        [DisplayName("Название студии")]
        public string Name { get; set; }

        [DisplayName("Год основания")]
        public int EstablishedYear { get; set; }

        [DisplayName("Страна")]
        public string Country { get; set; }

        [DisplayName("Телефон")]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }

        [DisplayName("Количество фильмов")]
        public int FilmCount { get; set; }

        [DisplayName("Описание")]
        public string Description { get; set; }
    }
}
