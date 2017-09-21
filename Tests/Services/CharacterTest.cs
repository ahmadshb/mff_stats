using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MFFStats.Services;
using MFFStats.Models.Domain;
using System.Collections.Generic;

namespace MFFStats.Tests.Services
{
    [TestClass]
    public class CharacterTest
    {
        [TestMethod]
        public void CharacterService_SelectAll_Test()
        {
            CharacterService svc = new CharacterService();
            List<Character> modelList = svc.SelectAll();
            Assert.IsNotNull(modelList);

        }
    }
}
