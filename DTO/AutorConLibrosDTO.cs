﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryNetCoreAPI.DTO
{
    public class AutorConLibrosDTO : AutorDTO
    {
        public List<LibroDTO> Libros { get; set; }
    }
}
