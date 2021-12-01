using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Entities.BaseObjects
{

    /// <summary>
    /// Объект словаря
    /// </summary>
    public class DictObject : TypeObject
    {
        /// <summary>
        /// Имя объекта словаря
        /// </summary>
        public string Name { get; set; }
    }
}
