﻿using Microsoft.AspNetCore.Mvc.Rendering;
using MyLibrary.Data;
using MyLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyLibrary.ViewModels
{
    public class BookEditViewModel
    {
        public Book Book { get; set; }

        public List<SelectListItem> Libraries { get; set; }

        public List<SelectListItem> Patrons { get; set; }

        public BookEditViewModel(ApplicationDbContext context)
        {
            Libraries = context.Library.Select(library =>
            new SelectListItem { Text = library.Name, Value = library.LibraryId.ToString() }).ToList();

            Patrons = context.Patron.Select(patron =>
            new SelectListItem { Text = patron.FullName, Value = patron.PatronId.ToString() }).ToList();

            Patrons.Insert(0, new SelectListItem { Text = "Not Checked Out", Value = "" });
        }
    }
}
