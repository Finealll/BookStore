using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using BookStore.Entities.BookAdditionals;

namespace BookStore.Entities.Products
{
    /// <summary>
    /// Товар - Книга
    /// </summary>
    public class Book : BaseObjects.ProductObject
    {
        /// <summary>
        /// Получает и задает издателя
        /// </summary>
        public string Publisher { get; set; }

        /// <summary>
        /// Получает и задает год издания
        /// </summary>
        public int? YearOfPublishing { get; set; }

        /// <summary>
        /// Получает или задает ISBN
        /// </summary>
        public string ISBN { get; set; }

        /// <summary>
        /// Получает или задает Количество страниц
        /// </summary>
        public int? NumberOfPages { get; set; }

        /// <summary>
        /// Получает или задает Тираж
        /// </summary>
        public int? Circulation { get; set; }

        /// <summary>
        /// Получает или задает Жанр
        /// </summary>
        public virtual Jenre Jenre { get; set; }

        /// <summary>
        /// Получает или задает ID Жанра
        /// </summary>
        public int JenreId { get; set; }

        /// <summary>
        /// Получает или задает Автора
        /// </summary>
        public virtual Author Author { get; set; }

        /// <summary>
        /// Получает или задает Id автора
        /// </summary>
        public int AuthorId { get; set; }
    }
}
