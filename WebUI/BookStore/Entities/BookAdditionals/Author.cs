using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookStore.Entities.BaseObjects;

namespace BookStore.Entities.BookAdditionals
{
    public class Author : DictObject
    {
        /// <summary>
        /// Получает или задает Дату рождения автора
        /// </summary>
        public DateTime? Birthday;

        /// <summary>
        /// Получает или задает Дату смерти автора
        /// </summary>
        public DateTime? DayOfTheDead;

        /// <summary>
        /// Получает или задает Описание автора
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Получает или задает фото автора
        /// </summary>
        public string ImageLink { get; set; }
    }
}
