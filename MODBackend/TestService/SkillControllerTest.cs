﻿using System;
using System.Collections.Generic;
using System.Text;
using Moq;
using Xunit;
using TechnologyService.Repositories;
using TechnologyService.Models;
using TechnologyService.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace TestService
{
    public class SkillControllerTest
    {
        private readonly Mock<ISkillRepository> _repo;
        private readonly SkillController _controller;

        public SkillControllerTest()
        {
            _repo = new Mock<ISkillRepository>();
            _controller = new SkillController(_repo.Object);
        }
        [Fact]

        public void Get()
        {
            _repo.Setup(m => m.GetSkills()).Returns(GetSkillData());
            var result = _controller.Get() as List<Skill>;
            Assert.Equal(3, result.Count);
        }

        [Fact]

        public void GetByIdTest()
        {
            _repo.Setup(m => m.GetById("S2345")).Returns(GetSkillData()[0]);
            var result = _controller.GetS("S2345") as Skill;
           // Assert.NotNull(result);
            Assert.Equal("S2345", result.SkillId);
        }
        [Fact]
        public void Post()
        {
            var item = GetSkillData()[0];
            var result = _controller.Post(item) as OkResult;
            Assert.NotNull(result);
        }

        [Fact]
        public void Put()
        {
            var item = GetSkillData()[0];
            var result = _controller.Put(item) as OkResult;
            Assert.NotNull(result);
        }

        [Fact]
        public void Delete()
        {
            _repo.Setup(m => m.Delete(It.IsAny<string>()));
                var result = _controller.Delete("S2345") as OkResult;
            Assert.NotNull(result);
        }

        private List<Skill> GetSkillData()
        {
            return new List<Skill>()
            {
                new Skill(){SkillId="S2345",SkillName="Java"},
            new Skill() { SkillId = "S2346", SkillName = "Mean" },
            new Skill() { SkillId = "S2347", SkillName = "C#" }

            };

        }
    }
}
