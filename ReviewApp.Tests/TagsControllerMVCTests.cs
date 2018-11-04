using Microsoft.AspNetCore.Mvc;
using NSubstitute;
using ReviewApp.Controllers;
using ReviewApp.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ReviewApp.Tests
{
    public class TagsControllerMVCTests
    {
        TagsController underTest;
        ITagRepository tagRepo;


        public TagsControllerMVCTests()
        {
            tagRepo = Substitute.For<ITagRepository>();
            underTest = new TagsController(tagRepo);
        }

        [Fact]
        public void Index_Returns_A_View()
        {
            var result = underTest.Index();

            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Index_Returns_All_Tags()
        {
            var result = underTest.Index();
            tagRepo.Received().GetAll();
        }

        [Fact]
        public void Index_Sets_AllTags_As_Model()
        {
            var expectedModel = new List<Tag>();
            tagRepo.GetAll().Returns(expectedModel);

            var result = underTest.Index();

            var model = result.Model;
            Assert.Equal(expectedModel, model);
        }

        [Fact]
        public void Details_Returns_A_View()
        {
            
            
            var result = underTest.Details(1);
            Assert.IsType<ViewResult>(result);
        }
    }
}
