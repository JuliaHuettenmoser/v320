using System;
using Xunit;

namespace aStack.Tests
{
    public class ProgramTests
    {
        [Fact]
        public void Push_AddsElementToStack()
        {
            // Arrange
            Program stack = new Program();
            int value = 42;
            string input = "foo";

            // Act
            stack.Push(value, input);

            // Assert
            Assert.False(stack.IsEmpty);
        }

        [Fact]
        public void Pop_RemovesAndReturnsElementFromStack()
        {
            // Arrange
            Program stack = new Program();
            int value = 42;
            string input = "foo";
            stack.Push(value, input);

            // Act
            int poppedValue = stack.Pop();

            // Assert
            Assert.True(stack.IsEmpty);
            Assert.Equal(value, poppedValue);
        }

        [Fact]
        public void SwapXY_ThrowsNotImplementedException()
        {
            // Arrange
            Program stack = new Program();

            // Act & Assert
            Assert.Throws<NotImplementedException>(() => stack.SwapXY());
        }

        [Fact]
        public void Clear_RemovesAllElementsFromStack()
        {
            // Arrange
            Program stack = new Program();
            int value1 = 42;
            string input1 = "foo";
            int value2 = 84;
            string input2 = "bar";
            stack.Push(value1, input1);
            stack.Push(value2, input2);

            // Act
            stack.Clear();

            // Assert
            Assert.True(stack.IsEmpty);
        }

        [Fact]
        public void StringerMaker_ReturnsAllInputs()
        {
            // Arrange
            Program stack = new Program();
            int value1 = 42;
            string input1 = "foo";
            int value2 = 84;
            string input2 = "bar";
            stack.Push(value1, input1);
            stack.Push(value2, input2);

            // Act
            string allInputs = stack.StringerMaker(stack.newStack);

            // Assert
            Assert.Equal("[bar, foo]", allInputs);
        }
    }
}
