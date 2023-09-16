using Microsoft.VisualStudio.TestTools.UnitTesting;
using MementoDesignPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoDesignPattern.Tests
{
    [TestClass()]
    public class EditorTests
    {
        [TestMethod()]
        public void WritePropertyShouldUpdateText()
        {
            var editor = new Editor();

            editor.Write = "Plain Text";

            Assert.AreEqual("Plain Text", editor.Write);
        }

        [TestMethod()]
        public void UndoShouldRestorePreviousState()
        {
            var editor = new Editor();

            editor.Write = "Mucize";
            editor.Write = "Mucize Doktor";
            editor.Undo();

            Assert.AreEqual("Mucize", editor.Write);
        }

        [TestMethod()]

        public void UndoShouldNotThrowExceptionWhenNothingToUndo()
        {
            var editor = new Editor();
            //editor.Write = "Hello";
            //editor.Undo();

            editor.Undo();
            editor.Undo();
            Assert.AreEqual(null, editor.Write);
        }

    }
}