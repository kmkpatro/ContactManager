﻿using ContactManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ContactManager.Services;



namespace ContactManager.Controllers
{
    //public class ContactController : ApiController
    //{
    //    public Contact[] Get()
    //    {
    //        return new Contact[]
    //        {
    //    new Contact
    //    {
    //        Id = 1,
    //        Name = "Glenn Block"
    //    },
    //    new Contact
    //    {
    //        Id = 2,
    //        Name = "Dan Roth"
    //    }
    //        };
    //    }
    //}

    //[Route("api/[controller]")]
    public class ContactController : ApiController
    {
        private ContactRepository contactRepository;

        public ContactController()
        {
            this.contactRepository = new ContactRepository();
        }

        [HttpGet]
        public Contact[] Get()
        {
            return contactRepository.GetAllContacts();
        }
    }
}
