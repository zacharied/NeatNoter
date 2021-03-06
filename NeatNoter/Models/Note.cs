﻿using System.Collections.Generic;

namespace NeatNoter.Models
{
    public class Note : UniqueDocument
    {
        public ulong AssociatedCharacter { get; set; }

        public IList<Category> Categories { get; set; }
    }
}
