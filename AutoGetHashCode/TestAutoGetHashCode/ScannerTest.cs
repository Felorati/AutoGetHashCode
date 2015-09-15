﻿using System;
using System.Linq;
using AutoGetHashCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestAutoGetHashCode
{
    [TestClass]
    public class ScannerTest
    {
        private SyntaxAnalyzer _syntaxAnalyzer;
        private FileReader _fileReader;

        [TestInitialize]
        public void SetUp()
        {
            _fileReader = new FileReader();

        }

        [TestMethod]
        public void TestGenerateGetHashCode()
        {
        }
    }
}
