﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Controllers.Services;

namespace SalesWebMvc.Controllers
    {
    public class SellersController : Controller
        {


        private readonly SellerService _sellerService;

        public SellersController(SellerService SellerService)
            {
            _sellerService = SellerService;
            }

        public IActionResult Index()
            {

            var list = _sellerService.FindAll();

            return View(list);
            }
        }
    }
