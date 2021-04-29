using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Mvc2AjaxFetch15.Models;
using Mvc2AjaxFetch15.Services;
using Mvc2AjaxFetch15.ViewModels;

namespace Mvc2AjaxFetch15.Controllers
{
    public class PlayerController : Controller
    {
        private readonly IPlayerRepository _playerRepository;

        public PlayerController(IPlayerRepository playerRepository)
        {
            _playerRepository = playerRepository;
        }
        // GET
        public IActionResult Index()
        {
            var viewModel = new PlayerIndexViewModel();
            viewModel.Country = "Sweden";
            viewModel.ListGenerated = DateTime.Now;
            viewModel.Items = _playerRepository.GetList(0, 15).Select(r=>new PlayerRowViewModel
            {
                JerseyNumber = r.JerseyNumber,
                Position = r.Position,
                Namn = r.Name
            }).ToList();
            return View(viewModel);
        }


        public IActionResult GetPlayersFrom(int skip)
        {


            //return Content("<li>Hej från server</li>");
            var viewModel = new PlayerGetPlayersFromViewModel();
            //viewModel.Country = "Sweden";
            //viewModel.ListGenerated = DateTime.Now;
            viewModel.Items = _playerRepository.GetList(skip, 15).Select(r => new PlayerRowViewModel
            {
                JerseyNumber = r.JerseyNumber,
                Position = r.Position,
                Namn = r.Name
            }).ToList();
            return View(viewModel);
        }


    }
}