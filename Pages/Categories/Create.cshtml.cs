﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Nertan_Oana_Lab2.Data;
using Nertan_Oana_Lab2.Models;

namespace Nertan_Oana_Lab2.Pages.Categories
{
    public class CreateModel : PageModel
    {
        private readonly Nertan_Oana_Lab2.Data.Nertan_Oana_Lab2Context _context;

        public CreateModel(Nertan_Oana_Lab2.Data.Nertan_Oana_Lab2Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Category Category { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Category.Add(Category);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}