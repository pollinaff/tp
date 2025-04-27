using Microsoft.AspNetCore.Html;
using System.Reflection;
using tp_laba2.Models;

namespace tp_laba2.Helpers
{
    public static class FilmStudioHelpers
    {
        public static HtmlString ExternalHelperMethod(List<FilmStudio> studios)
        {
            var html = "<table class='table'><thead><tr><th>ID</th><th>Название студии</th><th>Год основания</th><th>Страна</th><th>Телефон</th><th>Количество фильмов</th><th>Описание</th><th>Действия</th></tr></thead><tbody>";

            for (int i = 0; i < studios.Count; i++)
            {
                var studio = studios[i];
                html += $"<tr><td>{studio.Id}</td><td>{studio.Name}</td><td>{studio.EstablishedYear}</td><td>{studio.Country}</td><td>{studio.Phone}</td><td>{studio.FilmCount}</td><td>{studio.Description}</td><td><a href='/FilmStudio/Details/{studio.Id}' class='btn btn-secondary'>Просмотр</a></td></tr>";
            }

            html += "</tbody></table>";
            return new HtmlString(html);
        }

        public static List<FilmStudio> GetMockFilmStudioList()
        {
            var studio = new List<FilmStudio>
            {
                new FilmStudio
                {
                    Id = 1,
                    Name = "Pixar ",
                    EstablishedYear = 1986,
                    Country = "США",
                    Phone = "+1 415-969-4400",
                    FilmCount = 23,
                    Description = "Американская анимационная студия, известная своими полнометражными фильмами"
                },
                new FilmStudio
                {
                    Id = 2,
                    Name = "Disney",
                    EstablishedYear = 1923,
                    Country = "США",
                    Phone = "+1 818-560-1000",
                    FilmCount = 150,
                    Description = "Одна из крупнейших медиакомпаний мира, создающая мультфильмы и фильмы."
                },
                new FilmStudio
                {
                    Id = 3,
                    Name = "Studio Ghibli",
                    EstablishedYear = 1985,
                    Country = "Япония",
                    Phone = "+81 3-3814-4191",
                    FilmCount = 22,
                    Description = "Японская анимационная студия, основанная Хаяо Миядзаки и Исао Такахатой."
                },
            };
            return studio;
        }
    }
}
