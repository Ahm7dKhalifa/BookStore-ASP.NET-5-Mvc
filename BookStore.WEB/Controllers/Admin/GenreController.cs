﻿using BookStore.BLL.Interfaces;
using System.Collections.Generic;
using System.Web.Mvc;
using AutoMapper;
using BookStore.BLL.DTO;
using BookStore.WEB.Models;

namespace BookStore.WEB.Controllers.Admin
{
    [Authorize(Roles = "admin")]
    public class GenreController : Controller
    {
        // GET: Genre
        private IBookService _bookService;
        private IAuthorService _authorService;
        private ICategoryService _categoryService;

        public GenreController(IBookService bookService, IAuthorService authorService, ICategoryService categoryService)
        {
            _categoryService = categoryService;
            _authorService = authorService;
            _bookService = bookService;
        }

        public ActionResult GetAllGenres()
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<CategoryDTO, CategoryViewModel>()).CreateMapper();
            var genres =
                mapper.Map<IEnumerable<CategoryDTO>, IEnumerable<CategoryViewModel>>(_categoryService.GetCategories());
              return PartialView("ShowGenres", genres);
        }
        public ActionResult Delete(int id)
        {
            _categoryService.DeleteGenre(id);
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<CategoryDTO, CategoryViewModel>()).CreateMapper();
            var genres =
                mapper.Map<IEnumerable<CategoryDTO>, IEnumerable<CategoryViewModel>>(_categoryService.GetCategories());
            return PartialView("ShowGenres", genres);
        }
        public ActionResult Edit(int id)
        {
            var genreDTO = _categoryService.GetGenre(id);
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<CategoryDTO, CategoryViewModel>()).CreateMapper();
            var viewModel = mapper.Map<CategoryDTO, CategoryViewModel>(genreDTO);
            return PartialView(viewModel);
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(CategoryViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                var mapper = new MapperConfiguration(cfg => cfg.CreateMap<CategoryViewModel, CategoryDTO>())
                    .CreateMapper();
                var genre = mapper.Map<CategoryViewModel, CategoryDTO>(viewModel);
                _categoryService.CreateGenre(genre);
                return RedirectToAction("Main", "Book");
            }

            return View(viewModel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(CategoryViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                var mapper = new MapperConfiguration(cfg => cfg.CreateMap<CategoryViewModel, CategoryDTO>()).CreateMapper();
                var genre = mapper.Map<CategoryViewModel, CategoryDTO>(viewModel);
                _categoryService.Update(genre);
                var genres = _categoryService.GetCategories();
                return PartialView("ShowGenres", genres);

            }

            return PartialView("Edit", viewModel);
        }
    }
}