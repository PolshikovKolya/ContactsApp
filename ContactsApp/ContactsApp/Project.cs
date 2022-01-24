﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApp
{
    /// <summary>
    /// Класс, содержащий лист всех контактов.
    /// </summary>
    public class Project
    {
        /// <summary>
        /// Лист, который хранит в себе список контактов.
        /// </summary>
        public List<PhoneContact> Contacts { get; set; } = new List<PhoneContact>();
    }
}
