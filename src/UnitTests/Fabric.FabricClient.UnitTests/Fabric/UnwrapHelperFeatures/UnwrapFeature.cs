using System;
using Xunit;

namespace MS.Extensions.Fabric.UnwrapHelperFeatures
{
    public interface IWrap
    {
        void Test();
    }

    internal abstract class BaseType
    {
        public void Test()
        {
            //do nothing
        }
    }

    internal class ValidType : BaseType, IWrap
    {
    }

    internal class InvalidType
    {
        public void Test()
        {
            //do nothing
        }
    }

    public class UnwrapFeature
    {
        [Fact]
        public void Interfaces_should_be_unwrapped_to_implementation_types()
        {
            IWrap wrapped = new ValidType();
            var unwrapped = wrapped.Unwrap<IWrap, ValidType>();
            Assert.IsType<ValidType>(unwrapped);
        }

        [Fact]
        public void Interfaces_should_be_unwrapped_to_base_types()
        {
            IWrap wrapped = new ValidType();
            var unwrapped = wrapped.Unwrap<IWrap, BaseType>();
            Assert.IsAssignableFrom<BaseType>(unwrapped);
        }

        [Fact]
        public void Unwrapping_invalid_types_should_should_throw_InvalidOperationException()
        {
            IWrap wrapped = new ValidType();
            Assert.Throws<InvalidOperationException>(() => wrapped.Unwrap<IWrap, InvalidType>());
        }
    }
}
