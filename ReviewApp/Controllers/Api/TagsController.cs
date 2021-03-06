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
            var tags = tagRepo.GetTagsForReviewId(reviewId);
            return tags;
        }

        [HttpPost]
        public bool Post([FromBody]Tag newTag, int reviewId)
        {
            newTag.ReviewTags = new List<ReviewTag>()
            {
                new ReviewTag() { ReviewId = reviewId }
            };
            tagRepo.Create(newTag);
            return true;
        }
    }
}
