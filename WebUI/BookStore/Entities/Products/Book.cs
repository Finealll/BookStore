using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BookStore.Entities.Products
{
    /// <summary>
    /// Товар - Книга
    /// </summary>
    public class Book : BaseObjects.ProductObject
    {
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
    }
}
