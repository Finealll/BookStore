using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Entities.BaseObjects
{
    /// <summary>
    /// Объект - тип. Имеет имя и дату создания
    /// </summary>
    public class TypeObject : BaseObject
    {
        /// <summary>
        /// Получает или задает Имя типа
        /// </summary>
        protected string TypeName { get; set; }

        /// <summary>
        /// Получает или задает Дату создания
        /// </summary>
        public DateTime? CreateDay { get; set; }


        /// <summary>
        /// Получает или задает Архивность типа
        /// </summary>
        public bool isArchived { get; set; } = false;

    }
}
