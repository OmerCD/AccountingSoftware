using Microsoft.VisualStudio.TestTools.UnitTesting;
using HomePage.CustomControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using HomePage.Classes;
using HomePage.Classes.Database.Entities;
using HomePage.CustomControls.MVC;

namespace HomePage.CustomControls.Tests
{
    [TestClass()]
    public class ContainerTests
    {
        private object _testObject = new DummyClass();
        [TestMethod()]
        public void ArrayInput_ReturnsLabelAndMultiControlWithLabelAndTextbox()
        {
            var method = typeof(Container).GetMethod("AddControl", BindingFlags.NonPublic | BindingFlags.Instance);
            var container = new Container(false);
            var propertyInfo = typeof(DummyClass).GetProperty("StringArray");
            var customAttribute = new CustomAttribute { FieldName = "testFieldName" };

            dynamic returnValue = method?.Invoke(container, new[] { propertyInfo, customAttribute, _testObject });

            Assert.IsInstanceOfType(returnValue.Item1, typeof(LabelAndMultiControl<LabelAndTextbox>));
        }
        [TestMethod]
        public void EnumInput_ReturnsComboBox()
        {
            var method = typeof(Container).GetMethod("AddControl", BindingFlags.NonPublic | BindingFlags.Instance);
            var container = new Container(false);
            var propertyInfo = typeof(DummyClass).GetProperty("TestEnums");
            var customAttribute = new CustomAttribute { FieldName = "testFieldName" };

            dynamic returnValue = method?.Invoke(container, new[] { propertyInfo, customAttribute, _testObject });

            Assert.IsInstanceOfType(returnValue.Item1, typeof(LabelAndCombobox));
        }
        [TestMethod]
        public void StringInput_ReturnsTextBox()
        {
            var method = typeof(Container).GetMethod("AddControl", BindingFlags.NonPublic | BindingFlags.Instance);
            var container = new Container(false);
            var propertyInfo = typeof(DummyClass).GetProperty("String");
            var customAttribute = new CustomAttribute { FieldName = "testFieldName" };

            dynamic returnValue = method?.Invoke(container, new[] { propertyInfo, customAttribute, _testObject });

            Assert.IsInstanceOfType(returnValue.Item1, typeof(LabelAndTextbox));
        }
        [TestMethod]
        public void BoolInput_ReturnsCheckBox()
        {
            var method = typeof(Container).GetMethod("AddControl", BindingFlags.NonPublic | BindingFlags.Instance);
            var container = new Container(false);
            var propertyInfo = typeof(DummyClass).GetProperty("Bool");
            var customAttribute = new CustomAttribute { FieldName = "testFieldName" };

            dynamic returnValue = method?.Invoke(container, new[] { propertyInfo, customAttribute, _testObject });

            Assert.IsInstanceOfType(returnValue.Item1, typeof(LabelAndCheckBox));
        }
        [TestMethod]
        public void DateTimeInput_ReturnsDateTimePicker()
        {
            var method = typeof(Container).GetMethod("AddControl", BindingFlags.NonPublic | BindingFlags.Instance);
            var container = new Container(false);
            var propertyInfo = typeof(DummyClass).GetProperty("DateTime");
            var customAttribute = new CustomAttribute { FieldName = "testFieldName" };

            dynamic returnValue = method?.Invoke(container, new[] { propertyInfo, customAttribute, _testObject });

            Assert.IsInstanceOfType(returnValue.Item1, typeof(LabelAndDatePicker));
        }
    }

    internal sealed class DummyClass
    {
        public string[] StringArray { get; set; } = { "test1", "test2", "test3" };
        public string String { get; set; } = "TestString";
        public bool Bool { get; set; } = false;
        public DateTime DateTime { get; set; }
        public User DbObject { get; set; } = new User();
        public User[] DbObjectArray { get; set; } = {new User(), new User()};
        public TestEnum TestEnums { get; set; }

        public enum TestEnum
        {
            test1,test2
        }
    }
}