﻿using Microsoft.AspNetCore.Mvc;
using ReviewApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewApp.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class TagsController : ControllerBase
    {
        private ITagRepository tagRepo;

        public TagsController(ITagRepository tagRepo)
        {
            this.tagRepo = tagRepo;
        }

        [HttpGet("{reviewId}")]
        public IEnumerable<Tag> Get(int reviewId)
        {
            return tagRepo.GetTagsForReviewId(reviewId);
        }

        [HttpPost]
        public bool Post([FromBody]Tag newTag)
        {
            tagRepo.Create(newTag);
            return true;
        }
    }
}
